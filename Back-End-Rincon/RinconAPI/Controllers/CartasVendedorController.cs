using RinconAPI.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using RinconDL.Entities;
using RinconBL.Services.IServices;

namespace RinconAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CartasVendedorController : Controller
    {
        private ICartaVendedorService _cartaVendedorService;

        public CartasVendedorController(ICartaVendedorService cartaVendedorService)
        {
            _cartaVendedorService = cartaVendedorService;
        }

        [HttpGet]
        public List<CartaVendedor> Get()
        {
            return _cartaVendedorService.GetAll();
        }
        [HttpPost]
        public void Post(CartaVendedor c)
        {
            _cartaVendedorService.Insert(c);
        }

        [HttpPut]
        public void Put(CartaVendedor cv)
        {
            _cartaVendedorService.Update(cv);
        }

        [HttpDelete]
        public void Delete(CartaVendedor cv)
        {
            _cartaVendedorService.Delete(cv);
        }
    }
}
