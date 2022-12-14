using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetById(int id);
        List<CarDetailDto> GetCarDetails();
        Car GetId(int id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

    }
}
