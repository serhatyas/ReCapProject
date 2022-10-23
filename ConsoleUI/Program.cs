using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());
            

            //Car car4 = new Car()
            //{
            //    CarName = "Lamborghini Valantino",
            //    BrandId = 1,
            //    ColorId = 1,
            //    DailyPrice = 9999000,
            //    ModelYear = 2021,
            //    Description = "Çiçek Gibi Araba"
            //};

            //carManager.Add(car4);

            //Car car5 = new Car() 
            //{
            //    Id=2009,
            //    CarName="Honda S2000",
            //    BrandId=4,
            //    ColorId=4,
            //    DailyPrice=90100,
            //    ModelYear=2000,
            //    Description="Güncellenen Araba2"
            //};

            //carManager.Update(car5);



            foreach (var item in carManager.GetCarDetails())
            {
                Console.WriteLine(item.CarName+" - "+item.BrandName + " - " +item.ColorName + " - " +item.ModelYear + " - " +item.DailyPrice);
            }

            //foreach (var item in carManager.GetAll())
            //{
            //    if (item.Id==3)
            //    {

            //        //carManager.Delete(item);
            //    }
            //    else
            //    {
            //        Console.WriteLine(item.Description);
            //        Console.WriteLine(carManager.);
            //    }

            //}

            //------------------------------------------------
            Console.WriteLine("-------------Car Bitti-------------");

            ColorManager colorManager = new ColorManager(new EfColorDal());
            //Color color = new Color() {ColorName="Turkuaz" };
            //colorManager.Add(color);

            foreach (var item in colorManager.GetAll())
            {
                Console.WriteLine(item.Id +" - "+item.ColorName);
            }

            //------------------------------------------------
            Console.WriteLine("-------------Color Bitti-------------");

            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //Brand brand = new Brand() { BrandName="TOGG"};

            //brandManager.Add(brand);

            foreach (var item in brandManager.GetAll())
            {
                Console.WriteLine(item.BrandName);
            }
        }
    }
}
