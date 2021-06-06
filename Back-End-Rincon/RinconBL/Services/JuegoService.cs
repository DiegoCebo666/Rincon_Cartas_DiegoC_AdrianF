
using RinconBL.Services.IServices;
using RinconDL.Entities;
using RinconDL.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RinconBL.Services
{
    public class JuegoService : IJuegoService
    {
        private readonly IUnitOfWork _uow;

        public JuegoService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public void Delete(Juego j)
        {
            throw new NotImplementedException();
        }

        public List<Juego> GetAll()
        {
            return _uow.Juego.GetAll().ToList();
        }

        public void Insert(Juego j)
        {
            _uow.Juego.Insert(j);
            _uow.Commit();
        }

        public void Update(Juego j)
        {
            throw new NotImplementedException();
        }
    }
}
