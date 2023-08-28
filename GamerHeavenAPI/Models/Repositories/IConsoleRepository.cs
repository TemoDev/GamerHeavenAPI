namespace GamerHeavenAPI.Models.Repositories
{
    public interface IConsoleRepository : IGeneralRepository<Console>
    {
        // If necessasry add console repository specific functions
        Task<PaginationData<Console>> GetAsync(string? name, string? searchQuery, int pageNumber, int pageSize);

    }
}
