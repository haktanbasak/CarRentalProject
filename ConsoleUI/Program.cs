using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entity.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetAll();
            //GetCarDetails();
            //CarAddTest();
            //GetCarsByBrandId();
            //GetCarsByColorId();
        }

        private static void GetCarsByColorId()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var item in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine("Car Id : " + item.Id + " Model Year : " + item.ModelYear + " Daily Price : " + item.DailyPrice + " Description : " + item.Description + " Color Id : " + item.ColorId);
            }
        }

        private static void GetCarsByBrandId()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var item in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine("Car Id : " + item.Id + " Model Year : " + item.ModelYear + " Daily Price : " + item.DailyPrice + " Description : " + item.Description + " Brand Id : " + item.BrandId);
            }
        }

        private static void CarAddTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Car car1 = new Car
            {
                Id = 3,
                BrandId = 3,
                ColorId = 3,
                ModelYear = "1990",
                DailyPrice = 150,
                Description = "Temiz araç"
            };

            carManager.Add(car1);
        }

        private static void GetCarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var item in carManager.GetCarDetailDtos())
            {
                Console.WriteLine("Model Year : " + item.ModelYear + " Brand Name : " + item.BrandName + " Color Name : " + item.ColorName + " Daily Price : " + item.DailyPrice);
            }
        }

        private static void GetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.ModelYear + " Model " + item.Description + " Günlük " + item.DailyPrice + " TL");
            }
        }
    }
}
