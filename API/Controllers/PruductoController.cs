using API.Data;
using API.Data.Model;
using API.Data.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PruductoController : ControllerBase
    {
        private readonly IProductoRepository _productoRepository;
        public PruductoController(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        // GET: api/<PruductoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _productoRepository.ListProductoAsync());
        }

        //// GET: api/<PruductoController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<PruductoController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _productoRepository.GetProductoByIdAsync(id));
        }

        // POST api/<PruductoController>
        [HttpPost]
        public void Post(Producto producto)
        {
            _productoRepository.Create(producto);
        }

        // PUT api/<PruductoController>
        [HttpPut]
        public async Task<IActionResult> Put(Producto producto)
        {
            _productoRepository.Edit(producto);
            return Ok();
        }

        // DELETE api/<PruductoController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            _productoRepository.Delete(id);

            return Ok();

        }
    }
}
