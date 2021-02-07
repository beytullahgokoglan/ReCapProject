using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=1999,DailyPrice=200,Description="Renaut" },
                new Car{Id=2,BrandId=2,ColorId=2,ModelYear=2005,DailyPrice=300,Description="Opel" },
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=1999,DailyPrice=200,Description="Chevrolet" },
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=1999,DailyPrice=200,Description="Tofaş" },
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=1999,DailyPrice=200,Description="BMW" },

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(p => p.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
