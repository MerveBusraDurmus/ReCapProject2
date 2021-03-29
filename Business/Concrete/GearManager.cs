using Business.Abstract;
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

        public void Add(Gear gear)
        {
            _gearDal.Add(gear);
        }

        public void Delete(Gear gear)
        {
            _gearDal.Delete(gear);
        }

        public List<Gear> GetAll()
        {
            return _gearDal.GetAll();
        }

        public void Update(Gear gear)
        {
            _gearDal.Update(gear);
        }
    }
}
