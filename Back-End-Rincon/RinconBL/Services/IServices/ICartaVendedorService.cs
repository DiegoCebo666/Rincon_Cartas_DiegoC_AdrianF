using RinconDL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RinconBL.Services.IServices
{
    public interface ICartaVendedorService
    {
        public List<CartaVendedor> GetAll();
        public void Insert(CartaVendedor u);
        public void Update(CartaVendedor u);
        public void Delete(CartaVendedor u);
    }
}
