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
    public class UsuariosController : Controller
    {
        private IUsuarioService _usuarioService;

        public UsuariosController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public List<Usuario> Get()
        {
            return _usuarioService.GetAll();
        }

        [HttpGet("UserById/{id}")]
        public Usuario GetCartasCarritoId(int id)
        {
            return _usuarioService.GetById(id);
        }

        [HttpGet("login/{nombre}/{pass}")]
        public bool Login(string nombre, string pass)
        {
            Usuario user = new Usuario();
            user.UserName = nombre;
            user.Password = pass;
            return _usuarioService.Login(nombre, pass);
        }

        [HttpPost("register/{nombre}/{email}/{pass}/{pass2}")]
        public int Register(string nombre, string email, string pass, string pass2)
        {
            if(pass != pass2)
            {
                return 0;
            }
            else
            {
                Usuario u = new Usuario { UserName = nombre, Email = email, Password = pass, Seller = false};
                _usuarioService.Insert(u);
                return 1;
            }
        }

        [HttpPost]
        public void Post(Usuario u)
        {
            _usuarioService.Insert(u);
        }

    }
}