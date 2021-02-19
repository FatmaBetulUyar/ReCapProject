using DataAccess.Abstract;
using Entities.Concrete;
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
            new Car { Id=  1, BrandId=  1, ColorId=  1, DailyPrice=  100000, Description=  "Ford ", ModelYear=2018},
            new Car { Id = 2, BrandId = 2, ColorId = 1, DailyPrice = 150000, Description = "Toyota", ModelYear = 2019 },
            new Car { Id = 3, BrandId = 2, ColorId = 1, DailyPrice = 140000, Description = "Toyota", ModelYear = 2018 },
            new Car { Id = 4, BrandId = 3, ColorId = 2, DailyPrice = 120000, Description = "Audi", ModelYear = 2017 },
            new Car { Id = 5, BrandId = 3, ColorId = 2, DailyPrice = 200000, Description = "Audi", ModelYear = 2017 },  
            new Car { Id = 6, BrandId = 1, ColorId = 2, DailyPrice = 0,      Description = "Ford", ModelYear = 2016},   
        };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
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
            return _cars.Where(c => c.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            Car updateToCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            updateToCar.ColorId = car.ColorId;
            updateToCar.BrandId = car.BrandId;
            updateToCar.DailyPrice = car.DailyPrice;
            updateToCar.Description = car.Description;
            updateToCar.ModelYear = car.ModelYear;

        }
    }
}
