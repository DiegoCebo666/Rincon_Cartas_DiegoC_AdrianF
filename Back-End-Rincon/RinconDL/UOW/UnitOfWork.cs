using RinconDL.Contexts;
using RinconDL.Entities;
using RinconDL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace RinconDL.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RinconContext context;

        public UnitOfWork(RinconContext context)
        {
            this.context = context;
        }
        public void Commit()
        {
            context.SaveChanges();
        }
        
        public IRepository<Carrito> carrito;
        public IRepository<Carta> carta;
        public IRepository<CartaVendedor> cartavendedor;
        public IRepository<CartaCarrito> cartacarrito;
        public IRepository<Juego> juego;
        public IRepository<Pedido> pedido;
        public IRepository<Usuario> usuario;

        public IRepository<Carrito> Carrito => carrito ?? (carrito = new Repository<Carrito>(context));
        public IRepository<Carta> Carta => carta ?? (carta = new Repository<Carta>(context));
        public IRepository<Juego> Juego => juego ?? (juego = new Repository<Juego>(context));
        public IRepository<Pedido> Pedido => pedido ?? (pedido = new Repository<Pedido>(context));
        public IRepository<Usuario> Usuario => usuario ?? (usuario = new Repository<Usuario>(context));
        public IRepository<CartaVendedor> CartaVendedor => cartavendedor ?? (cartavendedor = new Repository<CartaVendedor>(context));
        public IRepository<CartaCarrito> CartaCarrito => cartacarrito ?? (cartacarrito = new Repository<CartaCarrito>(context));
    }
}
