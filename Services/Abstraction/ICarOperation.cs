using Car_Rent_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rent_App.Services.Abstraction
{
    public interface ICarOperation : IMainOperation<Car>
    {
        List<Car> GetFiveCar();
        int NumberOfCars();
        bool IsThereCarByID(int code);
        Car findCarByID(int code);
    }
}
