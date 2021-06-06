
using RinconBL.Services.IServices;
using RinconDL.Entities;
using RinconDL.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RinconBL.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IUnitOfWork _uow;

        public PedidoService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public void Delete(Pedido p)
        {
            throw new NotImplementedException();
        }

        public List<Pedido> GetAll()
        {
            return _uow.Pedido.GetAll().ToList();
        }
        public void Insert(int idCart)
        {
            double precioTotal = 0;
            var cartas = _uow.CartaCarrito.GetAll().Where(c => c.CarritoFId == idCart).ToList();
            cartas.ForEach(carta => precioTotal += _uow.CartaVendedor.GetAll().FirstOrDefault(c => c.CartaVendedorId == carta.CartaVendedorFId).Precio);
            Pedido p = new Pedido { CartFId = idCart, TotalPrice = precioTotal, Date = DateTime.Today.ToString(), Estado = "Pendiente de envío" };
            _uow.Pedido.Insert(p);
            cartas.ForEach(carta => _uow.CartaCarrito.Delete(carta.CartaCarritoId));
            _uow.Commit();
        }

        public void Update(Pedido p)
        {
            throw new NotImplementedException();
        }
    }
}
