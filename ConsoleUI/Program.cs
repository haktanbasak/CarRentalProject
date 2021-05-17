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
            //RentalAddTest();
            //CustomerAddTest();
            //RentalDeleteTest();

        }

        private static void RentalDeleteTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Delete(new Rental { Id = 7000 });
        }

        private static void CustomerAddTest()
        {
            Customer customer1 = new Customer
            {

                UserId = 2,
                CompanyName = "Rent Car"
            };

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(customer1);

            var result1 = customerManager.GetAll();

            if (result1.Success == true)
            {
                foreach (var customer in result1.Data)
                {
                    Console.WriteLine(customer.UserId + " " + customer.CompanyName);
                }
            }
            else
            {
                Console.WriteLine(result1.Message);
            }
        }

        private static void RentalAddTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            Rental rental1 = new Rental
            {
                CarId = 3,
                CustomerId = 3,
                RentDate = DateTime.Now,
                ReturnDate = DateTime.Now
            };

            rentalManager.Add(rental1);
        }

        private static void GetCarsByColorId()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarsByColorId(2);

            foreach (var item in result.Data)
            {
                Console.WriteLine("Car Id : " + item.Id + " Model Year : " + item.ModelYear + " Daily Price : " + item.DailyPrice + " Description : " + item.Description + " Color Id : " + item.ColorId);
            }
        }

        private static void GetCarsByBrandId()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarsByBrandId(1);

            foreach (var item in result.Data)
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

            var result = carManager.GetCarDetailDtos();

            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine("Model Year : " + item.ModelYear + " Brand Name : " + item.BrandName + " Color Name : " + item.ColorName + " Daily Price : " + item.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }

        private static void GetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAll();

            foreach (var item in result.Data)
            {
                Console.WriteLine(item.ModelYear + " Model " + item.Description + " Günlük " + item.DailyPrice + " TL");
            }
        }
    }
}
