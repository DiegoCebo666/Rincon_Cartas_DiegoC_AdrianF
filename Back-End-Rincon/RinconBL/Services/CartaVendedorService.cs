using RinconBL.Services.IServices;
using RinconDL.Entities;
using RinconDL.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RinconBL.Services
{
    public class CartaVendedorService : ICartaVendedorService
    {
        private IUnitOfWork _uow;

        public CartaVendedorService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public void Delete(CartaVendedor c)
        {
            _uow.CartaVendedor.Delete(c);
        }

        public List<CartaVendedor> GetAll()
        {
            return _uow.CartaVendedor.GetAll().ToList();
        }

        public List<Carta> GetCardsDifferentSellers()
        {
            return _uow.Carta.GetAll().ToList();
        }

        public void Insert(CartaVendedor c)//hacer insert a partir de Carta
        {
            _uow.CartaVendedor.Insert(c);
            _uow.Commit();
        }

        public void Update(CartaVendedor c)
        {
            _uow.CartaVendedor.Update(c);
        }
    }
}
