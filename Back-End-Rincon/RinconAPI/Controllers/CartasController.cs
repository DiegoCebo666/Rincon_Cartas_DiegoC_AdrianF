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
    public class CartasController : Controller
    {
        private ICartaService _cartaService;
        private ICartaVendedorService _cartaVendedorService;

        public CartasController(ICartaService cartaService)
        {
            _cartaService = cartaService;
        }

        [HttpGet]
        public List<Carta> Get()
        {
            return _cartaService.GetAll();
        }

        //Sacar carta por id
        [HttpGet("CardById/{idcard}")]
        public List<Carta> GetCardById(int idcard)
        {
            return _cartaService.FilterCardBySQL("SELECT * FROM Cartas WHERE CartaId = " + idcard);
        }

        //Sacar carta por id
        [HttpGet("CardsRand/{idjuego}")]
        public List<Carta> GetCardsRand(int idjuego)
        {
            return _cartaService.FilterCardBySQL("SELECT * FROM Cartas WHERE JuegoFId = " + idjuego + " ORDER BY RANDOM() LIMIT 8");
        }

        //Sacar carta por id y juego
        [HttpGet("CardById/{idcard}/{idjuego}")]
        public List<Carta> GetCardByIdAndGame(int idcard, int idjuego)
        {
            return _cartaService.FilterCardBySQL("SELECT * FROM Cartas WHERE CartaId = " + idcard + " AND JuegoFId = " + idjuego);
        }

        //Sacar cartas de un vendedor por un juego
        [HttpGet("CardsBySeller/{iduser}/{idjuego}")]
        public List<CartaVendedor> GetCardsBySeller(int iduser, int idjuego)
        {
            return _cartaService.FilterBySQL("SELECT * FROM CartasVendedor INNER JOIN Cartas ON CartaId = CartaFId INNER JOIN Usuarios ON UsuarioId = VendedorFId WHERE VendedorFId = " + iduser + " AND JuegoFId = " + idjuego);
        }

        [HttpGet("CardBySeller/{iduser}/{idcarta}")]
        public List<CartaVendedor> GetCardBySeller(int iduser, int idcarta)
        {
            return _cartaService.FilterBySQL("SELECT * FROM CartasVendedor INNER JOIN Cartas ON CartaId = CartaFId INNER JOIN Usuarios ON UsuarioId = VendedorFId WHERE VendedorFId = " + iduser + " AND CartaFId = " + idcarta);
        }

        [HttpGet("CardsDifferentSellers/{idcarta}")]
        public List<CartaVendedor> GetCardsDifferentSellers(int idcarta)
        {
            return _cartaService.FilterBySQL("SELECT * FROM CartasVendedor WHERE CartaFId = " + idcarta);
        }

        [HttpGet("CardsDifferentSellers/{idcarta}/{idjuego}")]
        public List<CartaVendedor> GetCardsDifferentSellersAndGames(int idcarta)
        {
            return _cartaService.FilterBySQL("SELECT * FROM CartasVendedor INNER JOIN Usuarios ON UsuarioId = VendedorFId WHERE CartaFId = " + idcarta  );
        }

        [HttpGet("CardsByName/{nombre}/{idjuego}")]
        public List<Carta> GetCardsByName(string nombre, int idjuego)
        {
            return _cartaService.FilterCardBySQL("SELECT * FROM Cartas WHERE CartaName LIKE '%" + nombre + "%'" + " AND JuegoFId = " + idjuego);
        }

        [HttpGet("CardsByLanguage/{idioma}/{idcarta}")]
        public List<CartaVendedor> GetCardsByLanguage(string idioma, int idcarta)
        {
            return _cartaService.FilterBySQL("SELECT * FROM CartasVendedor INNER JOIN Cartas ON CartaId = CartaFId INNER JOIN Usuarios ON UsuarioId = VendedorFId WHERE Idioma = " + idioma + " AND CartaFId = " + idcarta);
        }

        [HttpGet("CardsByState/{estado}/{idcarta}")]
        public List<CartaVendedor> GetCardsByState(string estado, int idcarta)
        {
            return _cartaService.FilterBySQL("SELECT * FROM CartasVendedor INNER JOIN Cartas ON CartaId = CartaFId INNER JOIN Usuarios ON UsuarioId = VendedorFId WHERE Estado = " + estado + " AND CartaFId = " + idcarta);
        }

        [HttpPost]
        public void Post(Carta c)
        {
            _cartaService.Insert(c);
        }

        [HttpPost("AddCardSeller/{cantidad}/{precio}/{userid}")]
        public void PostCartaVendedor(Carta c, int cantidad, int precio, int userid)
        {
            _cartaService.InsertCartaVendedor(c, cantidad, precio, userid);
        }
    }
}
