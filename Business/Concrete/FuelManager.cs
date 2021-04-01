using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Fuel fuel)
        {
            _fuelDal.Add(fuel);
            return new SuccessResult(Messages.FuelTypeAdded);
        }

        public IResult Delete(Fuel fuel)
        {
            _fuelDal.Delete(fuel);
            return new SuccessResult(Messages.FuelTypeDeleted);
        }

        public IDataResult<List<Fuel>> GetAll()
        {
            return new SuccessDataResult<List<Fuel>>(_fuelDal.GetAll(),Messages.FuelTypesListed);
        }

        public IDataResult<Fuel> GetById(int fuelId)
        {
            return new SuccessDataResult<Fuel>(_fuelDal.Get(f => f.Id == fuelId),Messages.FuelTypeListed);
        }

        public IResult Update(Fuel fuel)
        {
            _fuelDal.Update(fuel);
            return new SuccessResult(Messages.FuelTypeUpdated);
        }
    }
}
