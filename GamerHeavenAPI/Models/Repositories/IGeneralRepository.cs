namespace GamerHeavenAPI.Models.Repositories
{
    public interface IGeneralRepository<T>
    {
        Task<IEnumerable<T>> GetAsync();
        Task<T?> GetByIdAsync(int id);
        Task AddAsync(T console);
        void RemoveAsync(T console);
        Task<bool> SaveChangesAsync();
    }
}
