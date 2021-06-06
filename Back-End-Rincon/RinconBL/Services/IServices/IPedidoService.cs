using RinconDL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RinconBL.Services.IServices
{
    public interface IPedidoService
    {
        public List<Pedido> GetAll();
        public void Insert(int idCart);
        public void Update(Pedido p);
        public void Delete(Pedido p);
    }
}
