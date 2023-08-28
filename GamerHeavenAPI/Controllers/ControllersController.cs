using GamerHeavenAPI.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GamerHeavenAPI.Controllers
{
    [Route("api/controllers")]
    [ApiController]
    public class ControllersController : ControllerBase
    {
        private readonly IControllerRepository _repository;

        public ControllersController(IControllerRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.Controller>>> GetConsoles(
            string? name, string? searchQuery, int pageNumber = 1, int pageSize = 3
            )
        {
            var paginationData = await _repository.GetAsync(name, searchQuery, pageNumber, pageSize);

            if (paginationData.Items == null)
            {
                return NotFound();
            }
            return Ok(paginationData);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Models.Controller>> GetConsole(int id)
        {
            var controller = await _repository.GetByIdAsync(id);
            if (controller == null) return NotFound();
            return Ok(controller);
        }

        [HttpPost]
        public async Task<ActionResult<Models.Controller>> AddConsole(Models.Controller controller)
        {
            await _repository.AddAsync(controller);
            await _repository.SaveChangesAsync();

            return CreatedAtAction("AddConsole",
                new
                {
                    Id = controller.Id,
                }, controller);
        }
    }
}
