using API.Data;
using API.Data.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PruductoController : ControllerBase
    {
        private readonly MyContext _context;
        public PruductoController(MyContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Get()
        {
            var productoRepository = new ProductoRepository(_context);
            return Ok(await productoRepository.ListProductiAsync());
        }

        //// GET: api/<PruductoController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<PruductoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PruductoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PruductoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PruductoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
