using API.Data;
using API.Data.Model;
using API.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;

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


        //ESTE si es el verdadero
        // GET api/<PruductoController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var producto = await _productoRepository.GetProductoByIdAsync(id);

            if (producto == null)
            {
                return NotFound();
            }

            return Ok(producto);
        }


        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetProducto(FileUpload fileObj, int id)
        //{
        //    var producto = await _productoRepository.GetProductoByIdAsync(id);
        //    //nuevo
        //    producto.Imagen = this.GetImagen(Convert.ToBase64String(producto.Imagen));
        //    //nuevo

        //    return Ok(producto);
        //}

        //public byte[] GetImagen(string sBase64String)
        //{
        //    byte[] bytes = null;
        //    if (!string.IsNullOrEmpty(sBase64String))
        //    {
        //        bytes = Convert.FromBase64String(sBase64String);
        //    }
        //    return bytes;
        //}

        // POST api/<PruductoController>

        [HttpPost("create")]
        public void Post(Producto producto)
        {
            _productoRepository.Create(producto);
        }


        //// POST api/<PruductoController>

        //[HttpPost("file")]
        //public string SaveFile(FileUpload fileObj)
        //{
        //    Producto oProducto = JsonConvert.DeserializeObject<Producto>(fileObj.Producto);
        //    if (fileObj.file.Length > 0)
        //    {
        //        using (var ms = new MemoryStream())
        //        {
        //            fileObj.file.CopyTo(ms);
        //            var fileBytes = ms.ToArray();
        //            oProducto.Imagen = fileBytes;
        //            _productoRepository.Create(oProducto);
        //            if (oProducto.Id > 0)
        //            {
        //                return "Guardado";
        //            }
        //        }
        //    }
        //    return "Fallo";
        //    //_productoRepository.Create(producto);
        //}


        // PUT api/<PruductoController>
        [HttpPut("update")]
        public async Task<IActionResult> Put(Producto producto)
        {
            _productoRepository.Edit(producto);
            return Ok();
        }

        // DELETE api/<PruductoController>/5
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            _productoRepository.Delete(id);

            return Ok();

        }
    }
}
