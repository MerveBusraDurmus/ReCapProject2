using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Car{Id=1, BrandId=1,ColorId=1, GearId=1, FuelId= 1, DailyPrice=100, ModelYear=2018},
                new Car{Id=2, BrandId=2,ColorId=2, GearId=1, FuelId= 2, DailyPrice=150, ModelYear=2019},
                new Car{Id=3, BrandId=5,ColorId=2, GearId=3, FuelId= 2, DailyPrice=200, ModelYear=2019},
                new Car{Id=4, BrandId=2,ColorId=4, GearId=2, FuelId= 3, DailyPrice=250, ModelYear=2020},
                new Car{Id=5, BrandId=1,ColorId=3, GearId=2, FuelId= 2, DailyPrice=300, ModelYear=2020},
                new Car{Id=6, BrandId=4,ColorId=2, GearId=3, FuelId= 1, DailyPrice=350, ModelYear=2019},
                new Car{Id=7, BrandId=1,ColorId=1, GearId=2, FuelId= 1, DailyPrice=400, ModelYear=2020},
                new Car{Id=8, BrandId=2,ColorId=1, GearId=1, FuelId= 2, DailyPrice=450, ModelYear=2021}

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

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByCarId(int carId)
        {
            return _cars.Where(p => p.Id == carId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.FuelId = car.FuelId;
            carToUpdate.GearId = car.GearId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
