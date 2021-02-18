﻿using DataAccess.Abstract;
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
            _cars = new List<Car>{
            new Car { Id=  1, BrandId=  1, ColorId=  1, DailyPrice=  100000, Descrription=  "Ford ", ModelYear=2018},
            new Car { Id = 2, BrandId = 2, ColorId = 1, DailyPrice = 150000, Descrription = "Toyota", ModelYear = 2019 },
            new Car { Id = 3, BrandId = 2, ColorId = 1, DailyPrice = 140000, Descrription = "Toyota", ModelYear = 2018 },
            new Car { Id = 4, BrandId = 3, ColorId = 1, DailyPrice = 120000, Descrription = "Audi", ModelYear = 2017 },
            new Car { Id = 5, BrandId = 3, ColorId = 1, DailyPrice = 200000, Descrription = "Audi", ModelYear = 2017 },
            new Car { Id = 6, BrandId = 1, ColorId = 1, DailyPrice = 300000, Descrription = "Ford", ModelYear = 2021 },
            new Car { Id = 7, BrandId = 4, ColorId = 1, DailyPrice = 500000, Descrription = "Mercedes", ModelYear = 2020 },
            new Car { Id = 8, BrandId = 1, ColorId = 1, DailyPrice = 100000, Descrription = "Ford", ModelYear = 2019 },
            new Car { Id = 9, BrandId = 1, ColorId = 1, DailyPrice = 155000, Descrription = "Ford", ModelYear = 2020 },
            new Car { Id = 10,BrandId = 3, ColorId = 1, DailyPrice = 100000, Descrription = "Audi", ModelYear = 2018 },

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

        public List<Car> GetAll()
        {
            return _cars;
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
            updateToCar.Descrription = car.Descrription;
            updateToCar.ModelYear = car.ModelYear;

        }
    }
}