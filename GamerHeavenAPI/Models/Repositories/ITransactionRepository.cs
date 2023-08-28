namespace GamerHeavenAPI.Models.Repositories
{
    public interface ITransactionRepository
    {
        Task<IEnumerable<TransactionBase>> GetTransactionsAsync(DateTime? start, DateTime? end, string? category);
        // If transaction was successful return true, else false
        Task<bool> AddTransactionAsync(TransactionBase transaction);
        Task<bool> SaveChangesAsync();

    }
}
