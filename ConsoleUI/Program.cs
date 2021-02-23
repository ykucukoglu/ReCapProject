using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
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
            Console.WriteLine("-----");
            Console.WriteLine("Id'si 2 olan araç:");
            foreach (var car in carManager.GetById(2))
            {
                Console.WriteLine("Açıklama:" + car.Description + " - Fiyat:" + car.DailyPrice);
            }
            Console.WriteLine("-----");
            carManager.Add(
                new Car { Id = 6, BrandId = 3, ColorId = 2, ModelYear = new DateTime(2021, 1, 1), DailyPrice = 156000, Description = "Yeni eklenen araç marka Audi" }
                );
            carManager.Update(
                 new Car { Id = 6, BrandId = 3, ColorId = 1, ModelYear = new DateTime(2021, 1, 1), DailyPrice = 250000, Description = "Audi araç bilgisi güncellendi" }
                );
            carManager.Delete(new Car { Id = 1 });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Açıklama:" + car.Description + " - Fiyat:" + car.DailyPrice);
            }
        }
    }
}
