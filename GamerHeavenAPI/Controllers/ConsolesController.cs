using GamerHeavenAPI.Models.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace GamerHeavenAPI.Controllers
{
    [Route("api/consoles")]
    [ApiController]
    public class ConsolesController : ControllerBase
    {
        private readonly IConsoleRepository _consoleContext;
        
        public ConsolesController(IConsoleRepository consoleContext)
        {
            _consoleContext = consoleContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.Console>>> GetConsoles(
            string? name, string? searchQuery, int pageNumber = 1, int pageSize = 3
            ) {
            var paginationData = await _consoleContext.GetAsync(name, searchQuery, pageNumber, pageSize);

            if(paginationData.Items == null)
            {
                return NotFound();
            }
            return Ok(paginationData);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Models.Console>> GetConsole(int id)
        {
            var console = await _consoleContext.GetByIdAsync(id);
            if(console == null) return NotFound();
            return Ok(console);
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<Models.Console>> AddConsole(Models.Console console)
        {
            await _consoleContext.AddAsync(console);
            await _consoleContext.SaveChangesAsync();

            return CreatedAtAction("AddConsole", 
                new
                {
                    Id = console.Id,
                }, console);
        }

        // Class for updating console object
        public class ConsoleToUpdate
        {
            public string Name { get; set; }
            public string Brand { get; set; }
            public string ReleaseDate { get; set; }
            public string Processor { get; set; }
            public string InternalMemory { get; set; }
            public string Ram { get; set; }
            public string Img { get; set; }
            public string Description { get; set; }
            public int Amount { get; set; }
        }

        [Authorize]
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateConsole(int id, Models.Console console)
        {
            var item = await _consoleContext.GetByIdAsync(id);
            if(item == null) return NotFound(); 

            item.Name = console.Name;
            item.Brand = console.Brand;
            item.ReleaseDate = console.ReleaseDate;
            item.Processor = console.Processor;
            item.InternalMemory = console.InternalMemory;
            item.Ram = console.Ram;
            item.Img = console.Img;
            item.Description = console.Description;
            item.Amount = console.Amount;

            await _consoleContext.SaveChangesAsync();

            return NoContent();
        }

        [Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteConsole(int id)
        {
            var item = await _consoleContext.GetByIdAsync(id);
            if(item == null) return NotFound();
            _consoleContext.RemoveAsync(item);
            await _consoleContext.SaveChangesAsync();
            return NoContent();
        }
    }
}
