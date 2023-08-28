using GamerHeavenAPI.Models.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace GamerHeavenAPI.Models.Repositories
{
    public class ControllerRepository : IControllerRepository
    {
        private readonly GamerHeavenDbContext _context;
        const int maxPageSize = 10;
        public ControllerRepository(GamerHeavenDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Controller item)
        {
            await _context.AddAsync(item);
        }

        public async Task<PaginationData<Controller>> GetAsync(string? name, string? seachQuery, int pageNumber, int pageSize)
        {
            if(pageSize > maxPageSize)
            {
                pageSize = maxPageSize;
            }
            var collection = _context.Controllers.AsQueryable();

            collection.Where(cl => string.IsNullOrWhiteSpace(name) || cl.Name == name)
                      .Where(cl => string.IsNullOrWhiteSpace(seachQuery) || (cl.Name.Contains(seachQuery) || cl.Platform.Contains(seachQuery)));

            var totalCount = await collection.CountAsync();

            var collectionToReturn = await
                collection.Skip(pageSize * (pageNumber - 1))
                .Take(pageSize)
                .ToListAsync();

            var paginationList = new PaginationData<Controller>(totalCount, pageSize, pageNumber, collectionToReturn);

            return paginationList;

        }

        public async Task<Controller?> GetByIdAsync(int id)
        {
            return await _context.Controllers.Where(c => c.Id == id).FirstOrDefaultAsync();
        }

        public void RemoveAsync(Controller item)
        {
            _context.Remove(item);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }
    }
}
