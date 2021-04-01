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
            return new SuccessResult(Messages.GearTypeAdded);
        }

        public IResult Delete(Gear gear)
        {
            _gearDal.Delete(gear);
            return new SuccessResult(Messages.GearTypeDeleted);
        }

        public IDataResult<List<Gear>> GetAll()
        {
            return new SuccessDataResult<List<Gear>>(_gearDal.GetAll(),Messages.GearTypesListed);
        }

        public IDataResult<Gear> GetById(int gearId)
        {
            return new SuccessDataResult<Gear>(_gearDal.Get(g => g.Id == gearId),Messages.GearTypeListed);
        }

        public IResult Update(Gear gear)
        {
            _gearDal.Update(gear);
            return new SuccessResult(Messages.GearTypeUpdated);
        }
    }
}
