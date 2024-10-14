using Car_Rent_App.DataBase;
using Car_Rent_App.Models;
using Car_Rent_App.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rent_App.Services.Concrete
{
    public class CarManager : ICarOperation
    {
        DB database = new();
        public void Add(Car t)
        {
            database.cars.Add(t);
        }

        public void Delete(int code)
        {
            var user = database.cars.Find(x=> x.ID == code);
            if (user != null)
            {
                database.cars.Remove(user);
            }
            else
            {
                Console.WriteLine("ID is wrong, try again");
            }
        }

        public bool IsThereCarByID(int code)
        {
            var user = database.cars.Find(x => x.ID == code);

            if(user == null)
            {
                return false;
            }
            return true;
        }


        public List<Car> GetFiveCar()
        {
            List<Car> list = new List<Car>();

            for(int i = 0; i < 5; i++)
            {
                list.Add(database.cars[i]);
            }
            return list;

        }

        public int NumberOfCars()
        {
            return database.cars.Count;
        }

        public List<Car> showAll()
        {
            return database.cars;
        }

        public void Update(int code, string updateBrand, string updateModel, int updateDoorCount, string updateFuelType)
        {
            var updateUser = database.cars.Find(x => x.ID == code);
            updateUser.Brand = updateBrand;
            updateUser.Model = updateModel;
            updateUser.DoorCount = updateDoorCount;
            updateUser.FuelType = updateFuelType;
            updateUser.Count = 1;

            Console.WriteLine("Car update successfully.");
        }

        public Car findCarByID(int code)
        {
            var user = database.cars.Find(x => x.ID == code);

            if(user != null)
            {
                return user;
            }
            return null;
        }
    }
}
