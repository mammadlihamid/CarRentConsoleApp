# 🚗 Car Rent Console Application

Welcome to the **Car Rent Console Application**! This is a console-based project written in **C#** as a part of an Object-Oriented Programming (OOP) course project. The application simulates a car rental management system that allows admins to perform various operations on the available car fleet. It includes features like data validation, an admin panel, and more.

This project aims to provide a simple yet effective car rental system, demonstrating the use of OOP concepts, modular architecture, and basic CRUD operations.

## 📂 Project Structure

The project is organized as follows:

```
Car Rent Project
├─ CarRentProject.csproj
├─ DataBase
│  └─ DB.cs
├─ Models
│  └─ Car.cs
├─ Program.cs
└─ Services
   ├─ Abstraction
   │  ├─ ICarOperation.cs
   │  └─ IMainOperation.cs
   └─ Concrete
      └─ CarManager.cs
```

The **Project Structure** is designed to separate concerns, making it easy to maintain and understand. Each component plays a specific role:
- **Models** represent the data objects (e.g., Car).
- **Services** provide the logic and operations for the project, divided into abstractions and concrete implementations.
- **Database** contains a simple in-memory list for storing cars.

## 🚀 Features

### 🏗️ Architecture
- **Object-Oriented Design**: The project follows good OOP practices with a modular structure that separates data models, services, and operations.
- **Layered Design**: The project is divided into different layers for ease of maintenance and scalability:
  - **Models**: Contains data representations (e.g., `Car` class).
  - **Services**: Contains abstractions (`ICarOperation`, `IMainOperation`) and concrete service implementations (`CarManager`).
  - **Database**: A simple in-memory data store (`DB.cs`) to hold car information.

The architecture is designed to be **modular and extensible**, allowing for easy upgrades and maintenance.

### 🏎️ Car Management
- **Add a New Car**: The user can add cars by specifying the car's attributes like brand, model, door count, fuel type, and type.
- **Delete a Car**: Remove a car from the fleet by providing the car's ID.
- **Update Car Information**: Update existing car information like brand, model, door count, fuel type, and type.
- **View Cars**:
  - **Show All Cars**: Displays all cars in the fleet, along with their details (e.g., ID, brand, model, door count, fuel type, count).
  - **Show 5 Cars**: Displays the first 5 cars in the fleet.

### 🔒 Data Validation
- **Input Validation**: The application contains extensive validation to ensure proper data entry:
  - Validations for car ID, brand name, model name, door count, and fuel type ensure that the inputs are correct and meet certain constraints.
  - Invalid entries are prompted for re-entry, ensuring that users provide correct data every time.

The data validation ensures reliability and minimizes the risk of incorrect data entry, enhancing the overall robustness of the application.

### 👥 Admin Panel
- **Console Menu**: The application has a menu-driven interface that lets the admin choose different operations, making it easy to manage cars in the system.
- **Admin Operations**:
  - **Rent a Car**: Users can "rent" a car by reducing the count of available cars. If no cars are available, the car is removed from the database.
  - **Clear Console**: Ability to clear the console for better readability.
  - **Exit Application**: Finish operations and safely exit.

The admin panel provides a **user-friendly experience**, making fleet management simple and intuitive.

### 📄 Code Features
- **Interfaces for Abstraction**:
  - `IMainOperation<T>`: Generic interface that provides methods for adding, deleting, updating, and showing all entities.
  - `ICarOperation`: Extends `IMainOperation` to add car-specific operations like getting a list of 5 cars, checking car existence by ID, and finding a car by ID.
- **Car Manager (`CarManager.cs`)**: Implements all the car-related operations. It interacts with the in-memory database (`DB.cs`) to manage the list of cars.

### 📋 Menu Options
The application provides the following operations:

1. **Add Car**
2. **Delete Car**
3. **Show 5 Cars**
4. **Show All Cars**
5. **Update Car Information**
6. **Rent a Car**
7. **Clear Console**
8. **Finish Operation**

## 🛠️ Getting Started

### 📥 How to Clone the Repository
1. **Copy the Repository URL**: On GitHub, click the green **Code** button and copy the URL.
2. **Open Terminal**: Open your terminal and navigate to your desired directory:
   ```bash
   cd /path/to/your/directory
   ```
3. **Clone the Repo**: Run the command below:
   ```bash
   git clone https://github.com/mammadlihamid/CarRentConsoleApp
   ```
4. **Navigate to the Project Directory**:
   ```bash
   cd CarRentConsoleApp
   ```

### Prerequisites
- **.NET SDK**: Make sure you have .NET SDK installed on your machine to run the project.
- **Dependencies**: The project requires .NET 5.0 or above.

### How to Run
1. Run the application using the following command:
   ```bash
   dotnet run
   ```
2. Follow the on-screen instructions to interact with the system.

If you encounter any issues during setup, ensure that your .NET SDK version matches the project requirements.

## 🚧 Future Improvements
- **Persistent Database**: Implement a database such as SQL Server or SQLite to store car information persistently.
- **User Interface Enhancements**: Upgrade from a console-based application to a GUI-based application using frameworks like WinForms or WPF.
- **User Management**: Add different user roles such as "Customer" and "Admin" with distinct permissions.

**Want to contribute?** Feel free to fork the repository and submit pull requests for any of the listed improvements. Contributions are always welcome!

## 🌟 Highlights
- **Simple and Effective**: A basic console-based car rental management system that serves as a great starting point for learning OOP principles.
- **Interactive Admin Panel**: Easy-to-use menu-based operations for managing the car fleet.
- **Validation**: Robust validation to ensure reliable data entry.

## 📬 Contact
Feel free to reach out to me for any suggestions or feedback:
- **Email**: hemid359@gmail.com  
- **GitHub**: [mammadlihamid](https://github.com/mammadlihamid)

Happy Coding! 😊🚀
