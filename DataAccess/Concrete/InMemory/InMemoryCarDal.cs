using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
       public List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=600, ModelYear=2015, Description="Dizel, otomatik, 1.6cc, 120HP"},
                new Car{Id=2, BrandId=2, ColorId=4, DailyPrice=500, ModelYear=2020, Description="Benzin, manuel, 1.3cc, 75HP"},
                new Car{Id=3, BrandId=2, ColorId=3, DailyPrice=800, ModelYear=2018, Description="LPG, Manuel, 1,1cc, 65HP"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var deletedCar = _cars.FirstOrDefault(p=>p.Id==car.Id);
            _cars.Remove(deletedCar);
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

        public List<Car> GetById(int id)
        {
            var selectedCar = _cars.Where(p=>p.Id==id).ToList();
            return selectedCar;
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            var updateedCar = _cars.FirstOrDefault(p => p.Id == car.Id);

            car.Id = updateedCar.Id;
            car.BrandId = updateedCar.BrandId;
            car.ColorId = updateedCar.ColorId;
            car.DailyPrice = updateedCar.DailyPrice;
            car.ModelYear = updateedCar.ModelYear;
            car.DailyPrice = updateedCar.DailyPrice;
        }


    }
}
