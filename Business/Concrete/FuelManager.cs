using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class FuelManager : IFuelService
    {
        IFuelDal _fuelDal;

        public FuelManager(IFuelDal fuelDal)
        {
            _fuelDal = fuelDal;
        }

        public void Add(Fuel fuel)
        {
            _fuelDal.Add(fuel);
        }

        public void Delete(Fuel fuel)
        {
            _fuelDal.Delete(fuel);
        }

        public List<Fuel> GetAll()
        {
            return _fuelDal.GetAll();
        }

        public Fuel GetById(int fuelId)
        {
            return _fuelDal.Get(f => f.Id == fuelId);
        }

        public void Update(Fuel fuel)
        {
            _fuelDal.Update(fuel);
        }
    }
}
