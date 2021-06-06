using RinconAPI.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using RinconBL.Services.IServices;
using RinconDL.Entities;

namespace RinconAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PedidosController : Controller
    {
        private IPedidoService _pedidoService;

        public PedidosController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpGet]
        public List<Pedido> Get()
        {
            return _pedidoService.GetAll();
        }

        //Añadir un pedido con un carrito asociado
        [HttpPost("{idCart}")]
        public void Post(int idCart)
        {
            _pedidoService.Insert(idCart);
        }

    }
}
