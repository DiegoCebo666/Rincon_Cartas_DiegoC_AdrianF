using RinconDL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RinconBL.Services.IServices
{
    public interface ICartaService
    {
        public List<Carta> GetAll();
        public List<CartaVendedor> FilterBySQL(string sql);
        public List<Carta> FilterCardBySQL(string sql);
        public void InsertCartaVendedor(Carta c, int cantidad, int precio, int userid);
        public void Insert(Carta c);
        public void Update(Carta c);
        public void Delete(Carta c);
    }
}
