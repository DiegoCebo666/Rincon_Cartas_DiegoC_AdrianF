
using RinconBL.Services.IServices;
using RinconDL.Entities;
using RinconDL.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RinconBL.Services
{
    public class CarritoService : ICarritoService
    {
        private readonly IUnitOfWork _uow;

        public CarritoService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public void AddCartaCarrito(CartaCarrito cc)
        {
            try
            {
                if (_uow.CartaCarrito.GetAll().ToList().FindAll(c => c.CarritoFId == cc.CarritoFId).ToList().FirstOrDefault(c => c.CartaVendedorFId == cc.CartaVendedorFId) != null)
                {
                    _uow.CartaCarrito.GetAll().ToList().FindAll(c => c.CarritoFId == cc.CarritoFId).ToList().FirstOrDefault(c => c.CartaVendedorFId == cc.CartaVendedorFId).FCantidad += cc.FCantidad;
                }
                else
                {
                    _uow.CartaCarrito.Insert(cc);
                }
                _uow.Commit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DeleteCartaCarrito(int idcart, int idcardvend)
        {
            try
            {
                _uow.CartaCarrito.Delete(_uow.CartaCarrito.GetAll().FirstOrDefault(c => c.CarritoFId == idcart && c.CartaVendedorFId == idcardvend).CartaCarritoId);
                _uow.Commit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Delete(Carrito c)
        {
            _uow.Carrito.Delete(c);
            _uow.Commit();
        }

        public List<Carrito> GetAll()
        {
            return _uow.Carrito.GetAll().ToList();
        }

        public List<CartaCarrito> GetCartasCarritoId(int id)
        {
            return _uow.CartaCarrito.GetAll().ToList().FindAll(c => c.CarritoFId == id).ToList();
        }

        public void Insert(Carrito c)
        {
            _uow.Carrito.Insert(c);
            _uow.Commit();
        }

        public void Update(Carrito c)
        {
            throw new NotImplementedException();
        }
    }
}
