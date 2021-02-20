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

            //GetAllTest(carmanager);
            //BrandIdTest(carmanager);
            //ColorIdTest(carmanager);

            //AddCarTest(carmanager);
            //AddColorTest(colorManager);
            //AddBrandTest(brandManager);


            //UpdateColorTest(colorManager);
            //UpdateCarTest(carmanager);

            //DeleteCarTest(carmanager);
            CarDetailsTest(carmanager);

        }

        private static void CarDetailsTest(CarManager carmanager)
        {
            foreach (var car in carmanager.GetCarDetails())
            {
                Console.WriteLine("Araba adı : " + car.CarName + "Markası : " + car.BrandName + "Rengi : " + car.ColorName + "Günlük Fiyatı : " + car.DailyPrice);
            }
        }

        private static void UpdateCarTest(CarManager carmanager)
        {
            carmanager.Update(new Car() { CarID = 1, BrandId = 2, ColorId = 1, CarName = "Toyota", DailyPrice = 1500, ModelYear = 2016 });
        }

        private static void UpdateColorTest(ColorManager colorManager)
        {
            colorManager.Update(new Color() { ColorId = 3, ColorName = "kırmızı" });
        }

        private static void AddBrandTest(BrandManager brandManager)
        {
            brandManager.Add(new Brand() { BrandId = 4, BrandName = "Mercedes" });
        }

        private static void AddColorTest(ColorManager colorManager)
        {
            colorManager.Add(new Color() { ColorId = 4, ColorName = "Mavi" });
            
        }

        private static void DeleteCarTest(CarManager carmanager)
        {
            carmanager.Delete(new Car() { CarID = 8 });
            
        }

        private static void ColorIdTest(CarManager carmanager)
        {
            foreach (var car2 in carmanager.GetCarsByColorId(2))
            {
                Console.WriteLine(car2.ColorId + " renk id li arabalar :" + car2.CarName);

            }
        }

        private static void AddCarTest(CarManager carmanager)
        {
            carmanager.Add(new Car()
            {
                CarID = 9,
                BrandId = 2,
                ColorId = 2,
                DailyPrice = 175000,
                ModelYear = 2018,
                CarName = "Toyota"
            }
           );
        }

        private static void GetAllTest(CarManager carmanager)
        {
            foreach (var car in carmanager.GetAll())
            {
                Console.WriteLine(car.CarName);
            }
        }

        private static void BrandIdTest(CarManager carmanager)
        {
            foreach (var car2 in carmanager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car2.BrandId + " id li arabalar :" + car2.CarName);

            }
        }
    }
}
