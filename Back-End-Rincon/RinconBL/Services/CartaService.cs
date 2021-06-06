using Newtonsoft.Json;
using RinconBL.Services.IServices;
using RinconDL.Entities;
using RinconDL.UOW;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;

namespace RinconBL.Services
{
    public class CartaService : ICartaService
    {
        private IUnitOfWork _uow;

        public CartaService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public void Delete(Carta c)
        {
            throw new NotImplementedException();
        }

        public List<Carta> GetAll()
        {
            return _uow.Carta.GetAll().ToList();
        }

        public List<CartaVendedor> FilterBySQL(string sql)
        {
            return _uow.CartaVendedor.GetBySQL(sql).ToList();
        }

        public List<Carta> FilterCardBySQL(string sql)
        {
            return _uow.Carta.GetBySQL(sql).ToList();
        }

        public void InsertCartaVendedor(Carta c, int cantidad, int precio, int userid)
        {
            CartaVendedor cv = new CartaVendedor { CartaFId = c.CartaId, CartaFName = c.CartaName, FImg = c.Img, VendedorFId = userid, Cantidad = cantidad, Precio = precio };
            _uow.CartaVendedor.Insert(cv);
            _uow.Commit();
        }

        public void Insert(Carta c)
        {
            _uow.Carta.Insert(c);
            _uow.Commit();
        }

        public void Update(Carta c)
        {
            throw new NotImplementedException();
        }
    }
}
