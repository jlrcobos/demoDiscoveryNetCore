using Api.Ventas.Model;
using Microsoft.Extensions.Configuration;
using RestEase;
using Steeltoe.Common.Discovery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Api.Ventas.Infraestructura
{
    public interface IProductoService
    {
        [Get("/")]
        Task<List<ProductosModel>> GetAllAsync();
    }
    public class ProductoService : IProductoService
    {
        private IProductoService _productoService;
        public ProductoService(IDiscoveryClient discoveryClient,IConfiguration configuration)
        {
            var handler = new DiscoveryHttpClientHandler(discoveryClient);
            var httpClient = new HttpClient(handler, false) {
                BaseAddress = new Uri(configuration["urlProductosServicios"])
            };
            this._productoService = RestClient.For<IProductoService>(httpClient);
        }
        public Task<List<ProductosModel>> GetAllAsync()
        {
            return this._productoService.GetAllAsync();
        }
    }
}
