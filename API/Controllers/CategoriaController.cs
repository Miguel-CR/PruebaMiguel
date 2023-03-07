using API.Data.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {

        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaController(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }
        // GET: api/<CategoriaController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _categoriaRepository.ListCategoriaAsync());
        }

        // GET api/<CategoriaController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _categoriaRepository.GetCategoriaByIdAsync(id));
        }


    }
}
