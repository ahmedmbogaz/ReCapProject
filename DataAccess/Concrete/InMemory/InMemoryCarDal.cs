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
                new Car {CarId=1, ColorId=1, BrandId=1, ModelYear=2011, DailyPrice=70000, Description="Temiz Araba Tıkırında"},
                new Car {CarId=2, ColorId=1, BrandId=2, ModelYear=2020, DailyPrice=100000, Description="Temiz Araba Tıkırında"},
                new Car {CarId=3, ColorId=2, BrandId=3, ModelYear=2015, DailyPrice=80000, Description="Temiz Araba Tıkırında"},
                new Car {CarId=4, ColorId=4, BrandId=3, ModelYear=2016, DailyPrice=70000, Description="Temiz Araba Tıkırında"},
                new Car {CarId=5, ColorId=5, BrandId=4, ModelYear=2019, DailyPrice=99000, Description="Temiz Araba Tıkırında"},
                new Car {CarId=6, ColorId=5, BrandId=4, ModelYear=2010, DailyPrice=59000, Description="Temiz Araba Tıkırında"},
                new Car {CarId=7, ColorId=5, BrandId=5, ModelYear=2013, DailyPrice=65000, Description="Temiz Araba Tıkırında"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId==car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = carToUpdate = _cars.SingleOrDefault(c => car.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
