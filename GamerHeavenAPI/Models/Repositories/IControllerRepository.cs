namespace GamerHeavenAPI.Models.Repositories
{
    public interface IControllerRepository : IGeneralRepository<Controller>
    {
        // If necesasry add Controller specific functions
        Task<PaginationData<Controller>> GetAsync(string? name, string? searchQuery, int pageNumber, int pageSize);

    }
}