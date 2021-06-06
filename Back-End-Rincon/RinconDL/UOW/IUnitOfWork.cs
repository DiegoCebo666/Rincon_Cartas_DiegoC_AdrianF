using RinconDL.Entities;
using RinconDL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace RinconDL.UOW
{
    public interface IUnitOfWork
    {
        void Commit();

        IRepository<Carrito> Carrito { get; }
        IRepository<Carta> Carta { get; }
        IRepository<CartaVendedor> CartaVendedor { get; }
        IRepository<CartaCarrito> CartaCarrito { get; }
        IRepository<Juego> Juego { get; }
        IRepository<Pedido> Pedido { get; }
        IRepository<Usuario> Usuario { get; }

    }
}
