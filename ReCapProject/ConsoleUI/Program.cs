using ReCapProject.Business.Abstract;
using ReCapProject.Business.Concrete;
using ReCapProject.DataAccess.Concrete.InMemory;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ReCapProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("//////////////////////");

            Car car1 = carManager.GetById(3);
            Console.WriteLine(car1.Description);

            Car car2 = new Car()
            {
                CarId = 3,
                ColorId = 2,
                BrandId = 5,
                Description = "Toyota Araba",
                DailyPrice = 1500,
                ModelYear = 2018
            };

            Console.WriteLine("TEST");
            Console.WriteLine(car1.BrandId + " " + car1.CarId + " " + car1.ColorId + " " + car1.DailyPrice + " " + car1.Description );
                        
            carManager.Update(car2);
            Console.WriteLine("Değişiyor");
            Console.WriteLine(car1.BrandId + " " + car1.CarId + " " + car1.ColorId + " " + car1.DailyPrice + " " + car1.Description);

            carManager.Delete(car1);
            Console.WriteLine("Siliniyor..");
            Console.WriteLine(car1.BrandId + " " + car1.CarId + " " + car1.ColorId + " " + car1.DailyPrice + " " + car1.Description);
                       
        }
    }
}
