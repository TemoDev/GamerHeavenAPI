namespace GamerHeavenAPI.Models.Repositories
{
    public interface IGeneralRepository<T>
    {
        Task<T?> GetByIdAsync(int id);
        Task AddAsync(T item);
        void RemoveAsync(T item);
        Task<bool> SaveChangesAsync();
    }
}

