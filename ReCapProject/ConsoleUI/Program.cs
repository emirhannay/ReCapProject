using ReCapProject.Business.Abstract;
using ReCapProject.Business.Concrete;
using ReCapProject.DataAccess.Concrete.EntityFramework;
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

            CarManager carManager1 = new CarManager(new EfCarDal());
            carManager1.Add(new Car { BrandId = 1, ColorId = 1, CarId = 1, DailyPrice = 250, Description = "BMW", ModelYear = 2010 });
                       
        }
    }
}
