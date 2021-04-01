using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFuelService
    {
        IDataResult<List<Fuel>> GetAll();
        IDataResult<Fuel> GetById(int fuelId);
        IResult Add(Fuel fuel);
        IResult Delete(Fuel fuel);
        IResult Update(Fuel fuel);
    }
}
