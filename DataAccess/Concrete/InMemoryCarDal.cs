using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
  public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars; //global değişken

        public InMemoryCarDal() //constructor metod
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,ColorId=3,ModelYear="2006",DailyPrice=300 ,Description="promosyon ve tekliflere açığız"},
                new Car{CarId=2,ColorId=5,ModelYear="2009",DailyPrice=450 ,Description="7/24 yol yardımı,rent a car kaskosu"},
                new Car{CarId=3,ColorId=2,ModelYear="2007",DailyPrice=350 ,Description="yerel vergiler bize ait, 7/24 yol yardımı"},
                new Car{CarId=4,ColorId=6,ModelYear="2019",DailyPrice=800 ,Description="promosyon ve tekliflere açığız, %100 güvenli kuruluş ve avantajlı fiyatlar"},
                new Car{CarId=5,ColorId=9,ModelYear="2021",DailyPrice=1000 ,Description="Online rezervasyonlarda %10 indirim"},
            
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId); //Linq kullanıldı.
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {

            return _cars; //veritabanındaki bilgileri olduğu gibi businessa aktar.
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int CarId)
        {
            return _cars.Where(c => c.CarId == CarId).ToList();
        }

        public List<Car> GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId); //Linq kullanıldı.

            carToUpdate.CarId = car.CarId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;


        }
    }
}
