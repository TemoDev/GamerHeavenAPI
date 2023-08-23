namespace GamerHeavenAPI.Models.Repositories
{
    public interface IConsoleRepository
    {
        public Task<IEnumerable<Console>> GetConsolesAsync();
        public Task<(IEnumerable<Console>, PaginationMetadata)> GetConsolesAsync(string? name, string? searchQuery, int pageNumber, int pageSize);
        public Task<Console?> GetConsoleByIdAsync(int id);
        public Task AddConsoleAsync(Console console);    
        public void RemoveConsoleAsync(Console console);
        public Task<bool> SaveChangesAsync();
        
        // Requests for controllers
        public Task<IEnumerable<Controller>?> GetConsoleControllersAsync(int id);


        // Requests for games


    }
}
