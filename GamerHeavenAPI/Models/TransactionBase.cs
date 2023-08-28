using Microsoft.EntityFrameworkCore;

namespace GamerHeavenAPI.Models
{
    [PrimaryKey("TransactionId")]
    public class TransactionBase
    {
        public int TransactionId { get; set; }
        public int CustomerId { get; set; }
        public string Category { get; set; } = string.Empty;
        public int ItemId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Amount { get; set; }

        public override string ToString()
        {
            return $"{TransactionId}, {CustomerId}, {Category}, {ItemId}, {PurchaseDate}, {Amount}";
        }

    }
}
