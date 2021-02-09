using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            
            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine("CarId : {0}--- BrandId : {1}",car.CarId, car.BrandId );
            }
            foreach (var car in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine("CarId : {0}--- ColorId : {1}", car.CarId, car.ColorId);
            }
        }
    }
}
