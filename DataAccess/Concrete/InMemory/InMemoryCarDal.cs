using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1,BrandId=1,ColorId=2,ModelYear=new DateTime(2020,1,1),DailyPrice=99000,Description="Deneme aracı 1"},
                new Car{Id=2,BrandId=3,ColorId=1,ModelYear=new DateTime(2012,1,1),DailyPrice=250000,Description="Deneme aracı 2"},
                new Car{Id=3,BrandId=2,ColorId=3,ModelYear=new DateTime(2021,1,1),DailyPrice=45600,Description="Deneme aracı 3"},
                new Car{Id=4,BrandId=1,ColorId=3,ModelYear=new DateTime(2010,1,1),DailyPrice=88000,Description="Deneme aracı 4"},
                new Car{Id=5,BrandId=3,ColorId=1,ModelYear=new DateTime(2019,1,1),DailyPrice=54699,Description="Deneme aracı 5"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(p => p.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
