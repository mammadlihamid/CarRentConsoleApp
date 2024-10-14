using Car_Rent_App.Models;
using Car_Rent_App.Services.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace mammadli.h
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager();
            while (true)
            {
                Console.WriteLine("Select operation (1, 2, 3, 4, 5, 6, 7): ");
                Console.WriteLine("1. Add Car");
                Console.WriteLine("2. Delete car");
                Console.WriteLine("3. Show 5 cars");
                Console.WriteLine("4. Show all cars");
                Console.WriteLine("5. Update data");
                Console.WriteLine("6. Rent Car");
                Console.WriteLine("7. Clear Console");
                Console.WriteLine("8. Finish operation");

                invalidOperationNumber:
                Console.WriteLine();
                Console.Write("Enter Operation Number: ");
                bool operationNumberValidation = int.TryParse(Console.ReadLine(), out int operationNumber);
                if(operationNumberValidation == false || (operationNumber < 1 || operationNumber > 8))
                {
                    Console.WriteLine("Invalid Number, try again.");
                    goto invalidOperationNumber;
                }

                switch (operationNumber)
                {
                    case 1:
                        invalidID:
                        Console.Write("ID: ");
                        bool idValidation = int.TryParse(Console.ReadLine(), out int id);
                        if(idValidation == false)
                        {
                            Console.WriteLine("Invalid ID, try again.");
                            goto invalidID;
                        }

                        if (carManager.IsThereCarByID(id))
                        {
                            var carByID = carManager.findCarByID(id);
                            carByID.Count++;
                        }

                        invalidBrandName:
                        Console.Write("Enter Brand name: ");
                        string brand = Console.ReadLine();
                        if(brand.Length <= 3)
                        {
                            Console.WriteLine("Show Brand Name, try again.");
                            goto invalidBrandName;
                        }

                        invalidModelName:
                        Console.Write("Enter Model: ");
                        string model = Console.ReadLine();
                        if (model.Length <= 3)
                        {
                            Console.WriteLine("Show Model Name, try again.");
                            goto invalidModelName;
                        }

                        invalidDoorCount:
                        Console.Write("Enter Door count: ");
                        int doorCount = Convert.ToInt32(Console.ReadLine());
                        if (doorCount == 0)
                        {
                            Console.WriteLine("Invalid Door Count, try again.");
                            goto invalidDoorCount;
                        }

                        invalidFuelType:
                        Console.Write("Enter Fuel type: ");
                        string fuelType = Console.ReadLine();
                        if (fuelType.Length <= 3)
                        {
                            Console.WriteLine("Show Fuel Type, try again.");
                            goto invalidFuelType;
                        }

                        invalidCarType:
                        Console.Write("Enter Car Type: ");
                        string type = Console.ReadLine();
                        if (type.Length <= 2)
                        {
                            Console.WriteLine("Show Type Name, try again.");
                            goto invalidCarType;
                        }

                        Car car = new Car()
                        {
                            ID = id,
                            Brand = brand,
                            Count = 1,
                            Model = model,
                            DoorCount = doorCount,
                            FuelType = fuelType,
                            Type = type,
                        };

                        carManager.Add(car);
                        break;

                    case 2:
                        invalidDeleteCarID:
                        Console.Write("Write ID: ");
                        bool deleteCarValidation = int.TryParse(Console.ReadLine(), out int deleteCarID);
                        if(deleteCarValidation == false)
                        {
                            Console.WriteLine("Invalid Code, try again.");
                            goto invalidDeleteCarID;
                        }

                        carManager.Delete(deleteCarID);
                        break;

                    case 3:
                        if (carManager.NumberOfCars() < 5)
                        {
                            Console.WriteLine("You dont have 5 cars, try again");
                        }
                        else
                        {
                            carManager.GetFiveCar();
                        }
                        break;

                    case 4:
                        List<Car>showAllCar = carManager.showAll();
                        foreach (var item in showAllCar)
                        {
                            Console.WriteLine($"Car ID: {item.ID} \n" +
                                $"Car Brand: {item.Brand} \n" +
                                $"Car Model: {item.Model} \n" +
                                $"Car Door Count: {item.DoorCount} \n" +
                                $"Car Fuel Type: {item.FuelType} \n" +
                                $"Car Type: {item.Type} \n" +
                                $"Car Count: {item.Count}");
                        }
                        break;

                    case 5:
                        invalidUpdateCarCode:
                        Console.Write("Enter Car ID: ");
                        bool updateCarIDvalidation = int.TryParse(Console.ReadLine(), out int updateCarCode);
                        if (updateCarIDvalidation == false)
                        {
                            Console.WriteLine("Invalid ID, try again.");
                            goto invalidUpdateCarCode;
                        }

                        invalidUpdateBrandName:
                        Console.Write("Enter Brand name: ");
                        string updateBrand = Console.ReadLine();
                        if(updateBrand.Length <= 3)
                        {
                            Console.WriteLine("Invalid Brand Name, try again.");
                            goto invalidUpdateBrandName;
                        }

                        invalidUpdateModelName:
                        Console.Write("Enter Model name: ");
                        string updateModel = Console.ReadLine();
                        if(updateModel.Length <= 3)
                        {
                            Console.WriteLine("Invalid Model Name, try again.");
                            goto invalidUpdateModelName;
                        }

                        invalidUpdateDoorCount:
                        Console.Write("Enter Door Count: ");
                        int updateDoorCount = Convert.ToInt32(Console.ReadLine());
                        if (updateDoorCount == 0)
                        {
                            Console.WriteLine("Invalid Door Count, try again.");
                            goto invalidUpdateDoorCount;
                        }

                        invalidUpdateFuelType:
                        Console.Write("Enter Fuel Type: ");
                        string updateFuelType = Console.ReadLine();
                        if (updateFuelType.Length <= 3)
                        {
                            Console.WriteLine("Show Fuel Type, try again.");
                            goto invalidUpdateFuelType;
                        }

                        invalidUpdateCarType:
                        Console.Write("Enter Car Type: ");
                        string updateCarType = Console.ReadLine();
                        if (updateCarType.Length <= 2)
                        {
                            Console.WriteLine("Show Type Name, try again.");
                            goto invalidUpdateCarType;
                        }

                        carManager.Update(updateCarCode, updateBrand, updateModel, updateDoorCount, updateFuelType);
                        break;

                    case 6:
                        List<Car> showAllCarForRent = carManager.showAll();
                        foreach (var item in showAllCarForRent)
                        {
                            Console.WriteLine($"Car ID: {item.ID} \n" +
                                $"Car Brand: {item.Brand} \n" +
                                $"Car Model: {item.Model} \n" +
                                $"Car Door Count: {item.DoorCount} \n" +
                                $"Car Fuel Type: {item.FuelType} \n" +
                                $"Car Type: {item.Type} \n" +
                                $"Car Count: {item.Count}");
                        }
                        invalidRentCarID:
                        Console.Write("Enter ID: ");
                        bool rentIDvalidation = int.TryParse(Console.ReadLine(), out int rentID);
                        if (!carManager.IsThereCarByID(rentID) || !rentIDvalidation)
                        {
                            Console.WriteLine("Invalid ID, try again.");
                            goto invalidRentCarID;
                        }
                        else
                        {
                            var rentCar = carManager.findCarByID(rentID);
                            if (rentCar.Count == 0)
                            {
                                carManager.Delete(rentID);
                            }
                            else
                            {
                                rentCar.Count--;
                            }
                        }
                        break;

                    case 7:
                        Console.Clear();
                        break;

                    case 8:
                        return;

                }
                Console.WriteLine();
                Console.WriteLine("<----------------------------------------------->");
                Console.WriteLine();
            }
        }
    }
}
