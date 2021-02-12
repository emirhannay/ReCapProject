using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ReCapProject.DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
       
        public InMemoryCarDal()
        {
            
            _cars = new List<Car>
            {
                new Car{CarId = 1, BrandId = 1, ColorId = 2, DailyPrice = 1000, ModelYear = 2005, Description = "BMW Araba"},
                new Car{CarId = 2, BrandId = 2, ColorId = 1, DailyPrice = 500, ModelYear = 2008, Description = "Audi Araba"},
                new Car{CarId = 3, BrandId = 1, ColorId = 1, DailyPrice = 400, ModelYear = 2004, Description = "BMW Araba"},
                new Car{CarId = 4, BrandId = 2, ColorId = 3, DailyPrice = 300, ModelYear = 2001, Description = "Audi Araba"},
                new Car{CarId = 5, BrandId = 3, ColorId = 2, DailyPrice = 200, ModelYear = 2015, Description = "TOGG Araba"}

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
            Console.WriteLine(_cars.Count()); 
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public Car GetById(int CarId)
        {
            Car carFindingId = _cars.SingleOrDefault(c => c.CarId == CarId);
            return carFindingId;   
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;


        }
    }
}
