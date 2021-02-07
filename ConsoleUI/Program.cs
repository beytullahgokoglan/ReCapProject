using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                
                Console.WriteLine("Id:{0}\nBrandId:{1}\nColorId:{2}\nModelYear:{3}\nDailyPrice:{4}\nDescription:{5}",car.Id,car.BrandId,car.ColorId,car.ModelYear,car.DailyPrice,car.Description);
            }
        }
    }
}
