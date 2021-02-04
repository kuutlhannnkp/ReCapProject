using DataAccess.Abstract;
using Entities.Concrete;
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
                new Car{Id= 1, BrandId= 1, ColorId= 1, CarDailyPrice= 250, CarDescription="Mercedes Cla 200", CarModelYear=2017},
                new Car{Id= 2, BrandId= 2, ColorId= 1, CarDailyPrice= 350, CarDescription="Hyundai Ix35", CarModelYear=2015},
                new Car{Id= 3, BrandId= 3, ColorId= 1, CarDailyPrice= 550, CarDescription="Ford Fiesta", CarModelYear=2014},
                new Car{Id= 4, BrandId= 4, ColorId= 1, CarDailyPrice= 950, CarDescription="Tesla Model S", CarModelYear=2012},
                new Car{Id= 5, BrandId= 4, ColorId= 1, CarDailyPrice= 150, CarDescription="Tesla Model X", CarModelYear=2011}
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

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int Id)
        {
            Car car = _cars.SingleOrDefault(p => p.Id == Id);
            return car ;
        }

        public Car GetCarsByBrandId(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Car GetCarsByColorId(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.CarDailyPrice = car.CarDailyPrice;
            carToUpdate.CarModelYear = car.CarModelYear;
            carToUpdate.CarDescription = car.CarDescription;
        }
    }
}
