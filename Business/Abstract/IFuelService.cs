using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFuelService
    {
        List<Fuel> GetAll();
        void Add(Fuel fuel);
        void Delete(Fuel fuel);
        void Update(Fuel fuel);
    }
}
