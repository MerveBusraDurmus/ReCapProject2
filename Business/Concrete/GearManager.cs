using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class GearManager : IGearService
    {
        IGearDal _gearDal;

        public GearManager(IGearDal gearDal)
        {
            _gearDal = gearDal;
        }

        public IResult Add(Gear gear)
        {
            _gearDal.Add(gear);
            return new SuccessResult();
        }

        public IResult Delete(Gear gear)
        {
            _gearDal.Delete(gear);
            return new SuccessResult();
        }

        public IDataResult<List<Gear>> GetAll()
        {
            return new SuccessDataResult<List<Gear>>(_gearDal.GetAll());
        }

        public IDataResult<Gear> GetById(int gearId)
        {
            return new SuccessDataResult<Gear>(_gearDal.Get(g => g.Id == gearId));
        }

        public IResult Update(Gear gear)
        {
            _gearDal.Update(gear);
            return new SuccessResult();
        }
    }
}
