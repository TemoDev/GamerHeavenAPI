namespace GamerHeavenAPI.Models.Repositories
{
    public interface IConsoleRepository
    {
        public Task<IEnumerable<Console>> GetConsolesAsync();
        public Task<Console?> GetConsoleByIdAsync(int id);
        public Task AddConsoleAsync(Console console);    
        public void RemoveConsoleAsync(Console console);
        public Task<bool> SaveChangesAsync();
    }
}
