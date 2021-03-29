using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        Car GetById(Expression<Func<Car,bool>> filter);
        List<Car> GetAllByCarId(int carId);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);

    }
}
