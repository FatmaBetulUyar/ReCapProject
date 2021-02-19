using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carmanager = new CarManager(new EfCarDal());

            foreach (var car in carmanager.GetCarsByColorId(2))
            {
                Console.WriteLine(car.Description);
            }
            foreach (var car2 in carmanager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car2.Description);

            }

            carmanager.Add(new Car()
            {
                Id=7,
                BrandId=2,
                ColorId=1,
                DailyPrice=125000,
                ModelYear=2015,
                Description="Toyota"
            }
            );
        }
    }
}
