using Core.DataAccess.Entityframework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarProjectContext>, ICarDal
    {
        public List<Car> GetCarDetails()
        {
            using (CarProjectContext context = new CarProjectContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join p in context.Colors on c.ColorId equals p.ColorId

                             select new CarDetailDto
                             {
                                 CarID=c.CarID,
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = p.ColorName,
                                 DailyPrice = c.DailyPrice

                             };
                return result.ToList();
            }

        } 
    }
}
