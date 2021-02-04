
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace UiConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                BrandId = 1,
                ColorId = 2,
                CarDailyPrice = 255,
                CarModelYear = 2016,
                CarDescription = "KLİMALI, GENİŞ "
            });
            carManager.Add(new Car
            {
                BrandId = 1,
                ColorId = 2,
                CarDailyPrice = 2,
                CarModelYear = 2016,
                CarDescription = "Klimalı ve Ferah"
            });
            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine("Araç bilgisi: {0} Model Yılı: {1} Günlük Ücret: {2}", car.CarDescription, car.CarModelYear, car.CarDailyPrice);
            }
        }
    }
}
