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
                new Car{Id= 1, BrandId= 1, ColorId= 1, DailyPrice= 250, Description="Mercedes Cla 200", ModelYear=2017},
                new Car{Id= 2, BrandId= 2, ColorId= 1, DailyPrice= 350, Description="Hyundai Ix35", ModelYear=2015},
                new Car{Id= 3, BrandId= 3, ColorId= 1, DailyPrice= 550, Description="Ford Fiesta", ModelYear=2014},
                new Car{Id= 4, BrandId= 4, ColorId= 1, DailyPrice= 950, Description="Tesla Model S", ModelYear=2012},
                new Car{Id= 5, BrandId= 4, ColorId= 1, DailyPrice= 150, Description="Tesla Model X", ModelYear=2011}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int Id)
        {
            Car car = _cars.SingleOrDefault(p => p.Id == Id);
            return car ;
        }


        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
