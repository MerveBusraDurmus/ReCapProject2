using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _cardal;

        public CarManager(ICarDal cardal)
        {
            _cardal = cardal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice>0)
            {
                _cardal.Add(car);
            }
            else
            {
                throw new Exception("Araba'nın günlük fiyatı 0'dan büyük olmalıdır");
            }
            
        }

        public void Delete(Car car)
        {
            _cardal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _cardal.GetAll();
        }

        public Car GetById(int carId)
        {
            return _cardal.Get(c => c.Id == carId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _cardal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _cardal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _cardal.GetAll(c => c.ColorId == colorId);
        }

        public void Update(Car car)
        {
            _cardal.Update(car);
        }
    }
}
