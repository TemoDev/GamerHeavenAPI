namespace GamerHeavenAPI.Models.Repositories
{
    public interface IControllerRepository
    {
        Task<IEnumerable<Console>> GetControllerAsync();
        public Task<(IEnumerable<Console>, PaginationMetadata)> GetControllerAsync(string? name, string? searchQuery, int pageNumber, int pageSize);
        Task<Console?> GetControllerByIdAsync(int id);
        Task AddControllerAsync(Console console);
        void RemoveControllerAsync(Console console);
        Task<bool> SaveChangesAsync();
    }
}
