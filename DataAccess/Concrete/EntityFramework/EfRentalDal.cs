using Core.DataAccess.Entityframework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarProjectContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarProjectContext context=new CarProjectContext())
            {
                var result = from r in context.Rentals
                             join b in context.Customers on r.CustomerId equals b.CustomerId
                             join p in context.Cars on r.CarId equals p.CarId
                             

                             select new RentalDetailDto
                             {
                                 CustomerId=b.CustomerId,
                                 CarID = p.CarId,
                                 RentalId=r.RentalId,
                                 RentDate=r.RentDate,
                                 ReturnDate = (DateTime)r.ReturnDate

                             };
                return result.ToList();
            }
        }
    }
}
