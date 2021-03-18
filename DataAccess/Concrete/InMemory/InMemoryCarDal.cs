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
            _cars = new List<Car>
            {
                new Car {Id=1, BrandId=1,ColorId=1,ModelYear=1,DailyPrice=100,Description="üstü açık"},
                new Car {Id=2, BrandId=2,ColorId=2,ModelYear=2,DailyPrice=200,Description="vintage"},
                new Car {Id=3, BrandId=3,ColorId=3,ModelYear=3,DailyPrice=300,Description="retro"},
                new Car {Id=4, BrandId=4,ColorId=4,ModelYear=4,DailyPrice=400,Description="spor"},
                new Car {Id=5, BrandId=5,ColorId=5,ModelYear=5,DailyPrice=500,Description="modern"},

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
