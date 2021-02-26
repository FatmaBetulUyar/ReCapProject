using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carmanager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            //var result = carmanager.GetCarDetails();
            //if (result.Success == true)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        Console.WriteLine(car.CarName + "/" + car.BrandName);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

            RentalTest(rentalManager);

            DeliverTest(rentalManager);

        }

        private static void DeliverTest(RentalManager rentalManager)
        {
            var result2 = rentalManager.DeliverCar(1, DateTime.Now);
            Console.WriteLine(result2.Message);
        }

        private static void RentalTest(RentalManager rentalManager)
        {
            var result = rentalManager.Add(new Rental()
            {
                CarId = 1,
                CustomerId = 2,
                RentalId = 2,
                RentDate = DateTime.Now
            });
            Console.WriteLine(result.Message);
        }
    }
}
