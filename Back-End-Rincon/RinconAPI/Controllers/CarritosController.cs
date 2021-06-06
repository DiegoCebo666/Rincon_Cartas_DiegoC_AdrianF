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
    public class CarritosController : Controller
    {
        private ICarritoService _carritoService;

        public CarritosController(ICarritoService carritoService)
        {
            _carritoService = carritoService;
        }

        [HttpGet]
        public List<Carrito> Get()
        {
            return _carritoService.GetAll();
        }

        //Sacar las cartas de un carrito
        [HttpGet("CartasCarrito/{id}")]
        public List<CartaCarrito> GetCartasCarritoId(int id)
        {
            return _carritoService.GetCartasCarritoId(id);
        }

        [HttpPost]
        public void Post(Carrito c)
        {
            _carritoService.Insert(c);
        }

        //Insertir una carta en un carrito
        [HttpPost("addCardCarrito")]
        public void AddCartaCarrito(CartaCarrito cc)
        {
            _carritoService.AddCartaCarrito(cc);
        }

        //Borrar una carta en un carrito
        [HttpDelete("deleteCardCarrito/{idCart}/{idCardVend}")]
        public void DeleteCartaCarrito(int idCart, int idCardVend)
        {
            _carritoService.DeleteCartaCarrito(idCart, idCardVend);
        }

        [HttpDelete]
        public void Delete(Carrito c)
        {
            _carritoService.Delete(c);
        }
    }
}
