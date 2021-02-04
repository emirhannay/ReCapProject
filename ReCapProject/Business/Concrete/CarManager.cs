using ReCapProject.Business.Abstract;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Concrete
{
    class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int CarId)
        {
            return _carDal.GetById(CarId);
        }
        public void Update(Car car)
        {
            _carDal.Update(car);
        }
        public void Add(Car car)
        {
            _carDal.Add(car);
        }
        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }
    }
}
