using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Ventas.Infraestructura;
using Api.Ventas.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Ventas.Controllers
{
    [Route("apiventas/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private IProductoService _productoService;
        public ProductosController(IProductoService productoService)
        {
            this._productoService = productoService;
        }
        [HttpGet]
        public async Task<List<ProductosModel>> Listar()
        {
            return await this._productoService.GetAllAsync();
        }
    }
}