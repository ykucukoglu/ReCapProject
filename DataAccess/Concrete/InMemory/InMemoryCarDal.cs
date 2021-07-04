using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{CarId=1,BrandId=1,ColorId=2,ModelYear="2020",DailyPrice=99000,Description="Deneme aracı 1"},
                new Car{CarId=2,BrandId=3,ColorId=1,ModelYear="2020",DailyPrice=250000,Description="Deneme aracı 2"},
                new Car{CarId=3,BrandId=2,ColorId=3,ModelYear="2020",DailyPrice=45600,Description="Deneme aracı 3"},
                new Car{CarId=4,BrandId=1,ColorId=3,ModelYear="2020",DailyPrice=88000,Description="Deneme aracı 4"},
                new Car{CarId=5,BrandId=3,ColorId=1,ModelYear="2020",DailyPrice=54699,Description="Deneme aracı 5"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(p => p.CarId == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
