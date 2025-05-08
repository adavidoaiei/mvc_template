# ASP.NET Core MVC CRUD Template

A full-featured ASP.NET Core MVC application template demonstrating CRUD operations and database management using Entity Framework Core.

![MVC Architecture](https://github.com/adavidoaiei/mvc_template/blob/main/mvc.png?raw=true)

## Features

- Complete CRUD operations for multiple entities:
  - Products (name, description, price, stock management)
  - Persons (first name, last name, age)
  - Tourism locations (location name, description, country, city, pricing)
  - Inventory management (name, quantity)
- Entity Framework Core with SQLite database
- Responsive views using Bootstrap
- Input validation and anti-forgery protection
- Async database operations

## Technology Stack

- ASP.NET Core 8.0
- Entity Framework Core
- SQLite Database
- Bootstrap for UI
- C# for backend logic

## Getting Started

1. Clone the repository
2. Ensure you have .NET 8.0 SDK installed
3. Navigate to the project directory
4. Run the following commands:
   ```
   dotnet restore
   dotnet ef database update
   dotnet run
   ```

## Project Structure

- `Controllers/`: Contains MVC controllers for each entity
- `Models/`: Entity model definitions
- `Views/`: Razor views for the UI
- `Data/`: Database context and configurations
- `Migrations/`: Database migration files

## Usage

Navigate to different sections through the navigation menu:
- `/Product` - Manage products
- `/Person` - Manage persons
- `/Tourism` - Manage tourism locations
- `/Home` - Manage inventory
