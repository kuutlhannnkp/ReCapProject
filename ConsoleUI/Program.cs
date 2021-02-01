
using Business.Concrete;
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
            CarManager carManager = new CarManager(new InMemoryCarDal());
            List<Car> _cars = carManager.GetAll();
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(
                    item.Id + " "
                    + item.BrandId + " "
                    + item.ColorId + " "
                    + item.ModelYear + " "
                    + item.DailyPrice + " "
                    + item.Description
                    ) ;
            }
            
        }
    }
}
