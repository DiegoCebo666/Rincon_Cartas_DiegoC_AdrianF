using RinconBL.Services.IServices;
using RinconDL.Entities;
using RinconDL.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RinconBL.Services
{
    public class UsuarioService : IUsuarioService
    {
        private IUnitOfWork _uow;

        public UsuarioService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public void Delete(Usuario u)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> GetAll()
        {
            return _uow.Usuario.GetAll().ToList();
        }

        public Usuario GetById(int iduser)
        {
            return _uow.Usuario.GetById(iduser);
        }

        public void Insert(Usuario u)
        {
            _uow.Usuario.Insert(u);
            _uow.Commit();
            _uow.Carrito.Insert(new Carrito { UsuarioFId = _uow.Usuario.GetAll().FirstOrDefault(user => user.Email == u.Email).UsuarioId });
            _uow.Commit();
        }

        public bool Login(string name, string password)
        {
            int user = _uow.Usuario.Login(name, password);
            if (object.Equals(user, 0))
            {
                return false;
            }
            return true;
        }

        public void Update(Usuario u)
        {
            throw new NotImplementedException();
        }
    }
}
