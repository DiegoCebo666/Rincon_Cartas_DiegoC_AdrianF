using RinconDL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RinconBL.Services.IServices
{
    public interface IJuegoService
    {
        public List<Juego> GetAll();
        public void Insert(Juego j);
        public void Update(Juego j);
        public void Delete(Juego j);
    }
}
