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
            GetAll();
            //Add();
        }
        private static void Add()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car();
            car.BrandId = 1;
            car.ColorId = 1;
            car.DailyPrice = 15000;
            car.Description = "spor araba";
            car.ModelYear = 1;
            carManager.Add(car);
        }

        private static void GetAll()

        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id);
            }
        }
    }
}
