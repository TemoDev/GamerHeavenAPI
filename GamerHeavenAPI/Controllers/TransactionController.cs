using GamerHeavenAPI.Models;
using GamerHeavenAPI.Models.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GamerHeavenAPI.Controllers
{
    [Route("api/transaction")]
    [Authorize]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionRepository _transactionRepository;
        public TransactionController(ITransactionRepository rep) {
            _transactionRepository = rep;
        }

        public class TransactionRequestBody
        {
            public int CustomerId { get; set; }
            public string Category { get; set; } = string.Empty;
            public int ItemId { get; set; }
            public int Amount { get; set; }
        }

        [HttpPost]
        public async Task<ActionResult> AddTransaction(TransactionRequestBody body)
        {
            var transaction = new TransactionBase
            {
                CustomerId = body.CustomerId,
                Category = body.Category,
                ItemId = body.ItemId,
                Amount = body.Amount,
                PurchaseDate = DateTime.UtcNow
            };

            bool madeTransaction = await _transactionRepository.AddTransactionAsync(transaction);
            if(madeTransaction)
            {
                await _transactionRepository.SaveChangesAsync();
                return CreatedAtAction("AddTransaction",
                    new
                    {
                        Id = transaction.TransactionId,
                    }, transaction);
            } else
            {
                return BadRequest();
            }
            
        }
        
        [HttpGet("export")]
        public async Task<ActionResult> GetHistory(DateTime? start, DateTime? end, string? category)
        {
            var transactions = await _transactionRepository.GetTransactionsAsync(start, end, category);
            if(transactions == null)
            {
                return NotFound();
            }

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, $"TransactionHistory_{Guid.NewGuid()}.csv")))
            {
                await outputFile.WriteLineAsync("TransactionId, CustomerId, Category, ItemId, PurchaseDate, Amount");
                foreach(var t in transactions) {
                    await outputFile.WriteLineAsync(t.ToString());
                }
            }

            return Ok();
        }
    }
}
