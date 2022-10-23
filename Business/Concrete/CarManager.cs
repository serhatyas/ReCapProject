using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _Car;

        public CarManager(ICarDal car)
        {
            _Car = car;
        }

        public void Add(Car car)
        {
            //string NewCar=Convert.ToString(car);

            if (car.CarName.Length>2 && car.DailyPrice>0)
            {
                _Car.Add(car);
                Console.WriteLine(car.CarName +" Aracı Eklendi");
            }
            else
            {
                Console.WriteLine("Araç eklenemedi");
            }

        }

        public void Delete(Car car)
        {
            _Car.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _Car.GetAll();
        }

        public List<Car> GetById(int id)
        {
            return _Car.GetAll(p=>p.BrandId==id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _Car.GetCarDetails();
        }

        public Car GetId(int id)
        {
            return _Car.Get(p=>p.Id==id);
        }

        public void Update(Car car)
        {
            _Car.Update(car);
        }

    }
}
