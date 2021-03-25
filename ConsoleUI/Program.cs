using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;


namespace ConsoleUI
{
   public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach ( var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId );
                Console.WriteLine(car.ColorId);
                Console.WriteLine(car.BrandId);
                Console.WriteLine(car.DailyPrice);
                Console.WriteLine(car.Description);
            }
        }
    }
}
