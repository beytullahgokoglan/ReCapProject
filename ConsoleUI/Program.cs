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
            Console.WriteLine("Car Test");
            CarTest();
            Console.WriteLine("Brand Test");
            BrandTest();
            Console.WriteLine("Color Test");

            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
            foreach (var color in colorManager.GetById(1))
            {
                Console.WriteLine(color.ColorName);
            }


        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
            foreach (var brand in brandManager.GetById(1))
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetailDtos())
            {
                Console.WriteLine(car.CarId + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice + "/" + car.ModelYear);
            }
            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine("CarId : {0}--- BrandId : {1}", car.CarId, car.BrandId);
            }
            foreach (var car in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine("CarId : {0}--- ColorId : {1}", car.CarId, car.ColorId);
            }
        }
    }
}
