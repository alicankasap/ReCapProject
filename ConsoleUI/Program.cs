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
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //brandManager.Update(new Brand { Id = 1002, Name = "Volvo" });

            //colorManager.Add(new Color { Name = "Siyah" });

            //carManager.Add(new Car { BrandId = 1002, ColorId = 1002, ModelYear = 2022, DailyPrice = 1000, Description = "XC40 T3 Automatic" });

            //carManager.Update(new Car { Id = 3, BrandId = 3, ColorId = 3, ModelYear = 2009, DailyPrice = 500, Description = "BMW 330d Automatic" });

            //carManager.Delete(new Car { Id = 2 });

            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine(car.CarName + " " + car.BrandName + " " + car.ColorName + " " + car.DailyPrice);
            //}

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine($"Id: {car.Id}   Model: {car.Description}\n");
            //}

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
