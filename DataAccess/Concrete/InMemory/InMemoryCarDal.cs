using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1,ColorId=1, GearId=1, FuelId= 1, DailyPrice=100, ModelYear=2018, Kilometer=120.000},
                new Car{Id=2, BrandId=2,ColorId=2, GearId=1, FuelId= 2, DailyPrice=150, ModelYear=2019, Kilometer=110.000},
                new Car{Id=3, BrandId=5,ColorId=2, GearId=3, FuelId= 2, DailyPrice=200, ModelYear=2019, Kilometer=100.000},
                new Car{Id=4, BrandId=2,ColorId=4, GearId=2, FuelId= 3, DailyPrice=250, ModelYear=2020, Kilometer=21.000},
                new Car{Id=5, BrandId=1,ColorId=3, GearId=2, FuelId= 2, DailyPrice=300, ModelYear=2020, Kilometer=20.000},
                new Car{Id=6, BrandId=4,ColorId=2, GearId=3, FuelId= 1, DailyPrice=350, ModelYear=2019, Kilometer=10.000},
                new Car{Id=7, BrandId=1,ColorId=1, GearId=2, FuelId= 1, DailyPrice=400, ModelYear=2020, Kilometer=12.000},
                new Car{Id=8, BrandId=2,ColorId=1, GearId=1, FuelId= 2, DailyPrice=450, ModelYear=2021, Kilometer=1.000},

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)  //???????
        {
           return _cars.Where(p => p.Id == carId).ToList();
           
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
