using GamerHeavenAPI.Models.DbContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GamerHeavenAPI.Models.Repositories
{
    public class ConsoleRepository : IConsoleRepository
    {
        public readonly GamerHeavenDbContext _context;
        public ConsoleRepository(GamerHeavenDbContext context) { _context = context; }

        public async Task<IEnumerable<Console>> GetConsolesAsync()
        {
            return await _context.Consoles.OrderBy(c => c.Name).ToListAsync();
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
