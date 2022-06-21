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

            //carManager.Add(new Car { BrandId = 3, ColorId = 3, ModelYear = 2009, DailyPrice = 5000, Description = "BMW 330d Automatic" });

            carManager.Update(new Car { Id = 3, BrandId = 3, ColorId = 3, ModelYear = 2009, DailyPrice = 500, Description = "BMW 330d Automatic" });

            //carManager.Delete(new Car { Id = 2 });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine($"Id: {car.Id}   Model: {car.Description}\n");
            }

            //foreach (var car in carManager.GetCarsByBrandId(1))
            //{
            //    Console.WriteLine($"Id: {car.Id}   Model: {car.Description}\n");
            //}

            //foreach (var car in carManager.GetCarsByColorId(2))
            //{
            //    Console.WriteLine($"Id: {car.Id}   Model: {car.Description}\n");
            //}

            //Console.WriteLine(carManager.GetById(3).Description);
        }
    }
}
