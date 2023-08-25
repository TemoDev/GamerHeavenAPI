namespace GamerHeavenAPI.Models.Repositories
{
    public interface IConsoleRepository
    {
        Task<IEnumerable<Console>> GetConsolesAsync();
        Task<(IEnumerable<Console>, PaginationMetadata)> GetConsolesAsync(string? name, string? searchQuery, int pageNumber, int pageSize);
        Task<Console?> GetConsoleByIdAsync(int id);
        Task AddConsoleAsync(Console console);    
        void RemoveConsoleAsync(Console console);
        Task<bool> SaveChangesAsync();
    }
}
