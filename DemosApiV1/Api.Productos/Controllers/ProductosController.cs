using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Productos.Infraestructura.data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Productos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private NortwindContext _nortwindContext;
        public ProductosController(NortwindContext nortwindContext)
        {
            this._nortwindContext = nortwindContext;
        }
        // GET: api/Productos
        [HttpGet]
        public List<Products> Get()
        {
            return this._nortwindContext.Products.ToList();
        }




        // GET: api/Productos/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Productos
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Productos/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
