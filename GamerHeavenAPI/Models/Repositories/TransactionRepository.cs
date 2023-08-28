using GamerHeavenAPI.Models.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace GamerHeavenAPI.Models.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly GamerHeavenDbContext _context;
        public TransactionRepository(GamerHeavenDbContext con) {
            _context = con;
        }

        // Helpers function to check if transaction can be made, and if it's valid
        private async Task<bool> IsValidTransaction(TransactionBase transaction)
        {
            string category = transaction.Category;

            // Check if item exists
            if (category.Equals("Consoles"))
            {
                var item = await _context.Consoles.Where(c => c.Category.Equals(category) && c.Id == transaction.ItemId).FirstOrDefaultAsync();
                // Check if there are enough items.
                if (item != null && item.Amount >= transaction.Amount)
                {
                    item.Amount -= transaction.Amount;
                }
                else
                {
                    return false;
                }
            }
            else if (category.Equals("Controllers"))
            {
                var item = await _context.Controllers.Where(c => c.Category.Equals(category) && c.Id == transaction.ItemId).FirstOrDefaultAsync();
                // Check if there are enough items.
                if (item != null && item.Amount >= transaction.Amount)
                {
                    item.Amount -= transaction.Amount;
                }
                else
                {
                    return false;
                }
            }
            else if (category.Equals("Games"))
            {
                var item = await _context.Games.Where(c => c.Category.Equals(category) && c.Id == transaction.ItemId).FirstOrDefaultAsync();
                // Check if there are enough items.
                if (item != null && item.Amount >= transaction.Amount)
                {
                    item.Amount -= transaction.Amount;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            return true;
        }

        public async Task<bool> AddTransactionAsync(TransactionBase transaction)
        {
            // Check if transaction can be made
            bool res = await IsValidTransaction(transaction);
            if(res)
            {
                await _context.Transactions.AddAsync(transaction);
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<TransactionBase>> GetTransactionsAsync(DateTime? start, DateTime? end, string? category)
        {
            var list = _context.Transactions.AsQueryable();

            return await
                list.Where(con => start == null || con.PurchaseDate > start)
                    .Where(con => end == null || con.PurchaseDate < end)
                    .Where(con => category == null || con.Category.Contains(category)).ToListAsync();
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }
    }
}
