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
            _cars = new List<Car>{
            new Car { CarId=  1, BrandId=  1, ColorId=  1, DailyPrice=  100000, CarName=  "Ford ", ModelYear=2018},
            new Car { CarId = 2, BrandId = 2, ColorId = 1, DailyPrice = 150000, CarName = "Toyota", ModelYear = 2019 },
            new Car { CarId = 3, BrandId = 2, ColorId = 1, DailyPrice = 140000, CarName = "Toyota", ModelYear = 2018 },
            new Car { CarId = 4, BrandId = 3, ColorId = 2, DailyPrice = 120000, CarName = "Audi", ModelYear = 2017 },
            new Car { CarId = 5, BrandId = 3, ColorId = 2, DailyPrice = 200000, CarName = "Audi", ModelYear = 2017 },  
            new Car { CarId = 6, BrandId = 1, ColorId = 2, DailyPrice = 0,      CarName = "Ford", ModelYear = 2016},   
        };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
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


        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car updateToCar = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            updateToCar.ColorId = car.ColorId;
            updateToCar.BrandId = car.BrandId;
            updateToCar.DailyPrice = car.DailyPrice;
            updateToCar.CarName = car.CarName;
            updateToCar.ModelYear = car.ModelYear;

        }

       
    }
}
