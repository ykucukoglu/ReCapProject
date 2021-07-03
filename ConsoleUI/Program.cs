using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 10, ColorId = 2, CarName = "Aston Martin", ModelYear = "2017", DailyPrice = 4250000, Description = "Model:Coupe,Gear: Automatic,Fuel: Gasoline,Engine Displacement: 5200 cc" });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine($"{car.CarName} - {car.ModelYear} - {car.DailyPrice} - {car.Description}");
            }
        }
    }
}
