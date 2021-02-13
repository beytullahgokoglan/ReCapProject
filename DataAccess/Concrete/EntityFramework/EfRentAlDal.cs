using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentACarContext rentACarContext = new RentACarContext())
            {
                var result = from r in rentACarContext.RentAls
                             join cr in rentACarContext.Cars
                             on r.CarId equals cr.CarId
                             join c in rentACarContext.Customers
                             on r.CustomerId equals c.CustomerId
                             join u in rentACarContext.Users
                             on c.UserId equals u.UserId
                             select new RentalDetailDto
                             {
                                 CarId = cr.CarId,
                                 UserId = u.UserId,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 CustomerId = c.CustomerId,
                                 CompanyName = c.CompanyName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                             };
                return result.ToList();
            }
        }


    }
}
