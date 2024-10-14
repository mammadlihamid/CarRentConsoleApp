using Car_Rent_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rent_App.Services.Abstraction
{
    public interface IMainOperation<T> where T : class
    {
        void Add(T t);
        void Delete(int code);
        Car findCarByID(int code);
        List<T> showAll();
        void Update(int code, string updateBrand, string updateModel, int updateDoorCount, string updateFuelType);
    }
}
