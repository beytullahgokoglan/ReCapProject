using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("*************Car Test*************\n");
            //CarTest();
            //Console.WriteLine("*************Brand Test********** \n");
            //BrandTest();
            //Console.WriteLine("*************Color Test*********** \n");
            //ColorTest();
            
           // UserTest();

            //CustomerTest();

            RentAlTest();




        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Customer customer = new Customer { CompanyName = "Kodlamaio", UserId = 1 };
            Customer customer2 = new Customer { CompanyName = "Kodlamaio2", UserId = 2 };
            Console.WriteLine(customerManager.Add(customer2).Message); 
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            User user = new User { FirstName = "Engin", LastName = "Demirog", Email = "engindemirog@gmail.com", Password = "1234" };
            User user2 = new User { FirstName = "Kübra", LastName = "Terzi", Email = "kubraterzi@gmail.com", Password = "1422" };
            Console.WriteLine(userManager.Add(user2).Message); 
        }

        private static void RentAlTest()
        {
            RentalManager rentAlManager = new RentalManager(new EfRentalDal());
           // RentAl rentAl = new RentAl { RentAlId = 10, CarId = 2, CustomerId = 2, RentDate = DateTime.Now, ReturnDate = new DateTime(2021, 2, 15) };
            //RentAl rentAl2 = new RentAl {  CarId = 3, CustomerId = 4, RentDate = DateTime.Now, ReturnDate = DateTime.Now };
            Rental rentAl3 = new Rental {CarId = 3, CustomerId = 4, RentDate = DateTime.Now };
            Console.WriteLine(rentAlManager.Add(rentAl3).Message); 
            //Console.WriteLine(rentAlManager.Delete(rentAl).Message); 
            //Console.WriteLine(rentAlManager.UpdateReturnDate(rentAl2).Message);
            

            foreach (var rentAldata in rentAlManager.GetAll().Data)
            {
                Console.WriteLine(rentAldata.RentAlId + "/" + rentAldata.CarId + "/" + rentAldata.CustomerId);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
            Console.WriteLine(colorManager.GetById(1).Data.ColorName +"\n");
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
            Console.WriteLine("\n");
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarId + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice + "/" + car.ModelYear);
            }
            Console.WriteLine("\n");

        }
    }
}
