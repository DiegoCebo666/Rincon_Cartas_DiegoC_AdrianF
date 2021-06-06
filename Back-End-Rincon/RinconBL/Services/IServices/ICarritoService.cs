using RinconDL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RinconBL.Services.IServices
{
    public interface ICarritoService
    {
        public List<Carrito> GetAll();
        public List<CartaCarrito> GetCartasCarritoId(int id);
        public void Insert(Carrito c);
        public void Update(Carrito c);
        public void AddCartaCarrito(CartaCarrito cc);
        public void DeleteCartaCarrito(int idcart, int idcardvend);
        public void Delete(Carrito c);
    }
}
