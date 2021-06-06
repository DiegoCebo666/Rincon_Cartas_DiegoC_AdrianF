using RinconDL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RinconBL.Services.IServices
{
    public interface IUsuarioService
    {
        public List<Usuario> GetAll();
        public Usuario GetById(int iduser);
        public void Insert(Usuario u);
        public bool Login(string name, string password);
        public void Update(Usuario u);
        public void Delete(Usuario u);
    }
}
