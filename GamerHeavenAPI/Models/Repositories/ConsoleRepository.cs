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

        public async Task<PaginationData<Console>> GetAsync(string? name, string? searchQuery, int pageNumber, int pageSize)
        {
            if(pageSize > maxPageSize) pageSize = maxPageSize;

            var collection = _context.Consoles.AsQueryable();

            collection = collection.Where(cl => string.IsNullOrWhiteSpace(name) || cl.Name == name)
                      .Where(cl => string.IsNullOrWhiteSpace(searchQuery) || cl.Name.Contains(searchQuery) || cl.Description.Contains(searchQuery));

            var totalItemCount = await collection.CountAsync();
            
            var collectionToReturn = await
                collection
                    .Skip(pageSize * (pageNumber - 1))
                    .Take(pageSize)
                    .ToListAsync();

            var paginationList = new PaginationData<Console>(totalItemCount, pageSize, pageNumber, collectionToReturn);
            
            return paginationList;
        }

        public async Task<Console?> GetByIdAsync(int id)
        {
            return await _context.Consoles.Where(c => c.Id == id).FirstOrDefaultAsync();
        }

        public async Task AddAsync(Console console)
        {
            await _context.AddAsync(console);
        }

        public void RemoveAsync(Console console)
        {
            _context.Remove(console);
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }
    }
}
