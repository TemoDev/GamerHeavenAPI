using GamerHeavenAPI.Models.DbContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GamerHeavenAPI.Models.Repositories
{
    public class ConsoleRepository : IConsoleRepository
    {
        public readonly GamerHeavenDbContext _context;
        const int maxPageSize = 10;
        public ConsoleRepository(GamerHeavenDbContext context) { _context = context; }

        public async Task<IEnumerable<Console>> GetConsolesAsync()
        {
            return await _context.Consoles.OrderBy(c => c.Name).ToListAsync();
        }

        public async Task<(IEnumerable<Console>, PaginationMetadata)> GetConsolesAsync(string? name, string? seachQuery, int pageNumber, int pageSize)
        {
            if(pageSize > maxPageSize) pageSize = maxPageSize;

            var collection = _context.Consoles.AsQueryable();

           
            collection.Where(cl => string.IsNullOrWhiteSpace(name) || cl.Name == name)
                      .Where(cl => string.IsNullOrWhiteSpace(seachQuery) || (cl.Name.Contains(seachQuery) || cl.Description.Contains(seachQuery)));


            if (!string.IsNullOrWhiteSpace(name))
            {
                name = name.Trim();
                collection = collection.Where(c => c.Name == name);
            }

            if (!string.IsNullOrWhiteSpace(seachQuery))
            {
                seachQuery = seachQuery.Trim();
                collection = collection.Where(c => c.Name.Contains(seachQuery) || c.Description.Contains(seachQuery));
            }

            var totalItemCount = await collection.CountAsync();
            var paginationMetadata = new PaginationMetadata(totalItemCount, pageSize, pageNumber);
     

            var collectionToReturn = await
                collection
                    .Skip(pageSize * (pageNumber - 1))
                    .Take(pageSize)
                    .ToListAsync();

            var paginationList = new PaginationList<Console>(totalItemCount, pageSize, pageNumber, collectionToReturn);
            var paginationList2 = new PaginationListGenereic<Console>(totalItemCount, pageSize, pageNumber, collectionToReturn);

            return (collectionToReturn, paginationMetadata);
        }

        public async Task<Console?> GetConsoleByIdAsync(int id)
        {
            return await _context.Consoles.Where(c => c.Id == id).FirstOrDefaultAsync();
        }

        public async Task AddConsoleAsync(Console console)
        {
            await _context.AddAsync(console);
        }

        public void RemoveConsoleAsync(Console console)
        {
            _context.Remove(console);
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }
    }
}
