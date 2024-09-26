# ProjectERP

**ProjectERP** is a modular, scalable Enterprise Resource Planning (ERP) system built with **ASP.NET Core** and **Entity Framework Core**. It follows **Clean Architecture** principles to ensure maintainability, testability, and separation of concerns. The API is designed to handle key features such as device registration, activation, and other business operations.

## Table of Contents

- [Features](#features)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
- [Database Setup](#database-setup)

---

## Features

- Modular project architecture following Clean Architecture principles.
- Device management through a RESTful API.
- Integration with SQL Server using Entity Framework Core.
- Layered architecture with clear separation between business logic, data access, and API.
- Easily extensible and maintainable codebase.

---

## Technologies Used

- **ASP.NET Core** (Web API)
- **Entity Framework Core** (SQL Server integration)
- **SQL Server** (Relational Database)
- **Dependency Injection** (for service management)
- **Migrations** (for database schema management)
- **C#** (for application logic)
- **Swagger** (for API documentation)

---

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- Visual Studio or Visual Studio Code (optional)

### Installation

1. **Clone the repository**:
    ```bash
    git clone https://github.com/stanlymathai/ProjectERP.git
    cd ProjectERP
    ```

2. **Restore dependencies**:
    ```bash
    dotnet restore
    ```

3. **Build the solution**:
    ```bash
    dotnet build
    ```

4. **Run the API**:
    ```bash
    cd ProjectERP.Api
    dotnet run
    ```

5. Navigate to `http://localhost:5154` in your browser. You should see the API running.

---

## Database Setup

This project uses **Entity Framework Core** for database interaction with SQL Server. To set up the database:

1. Open `appsettings.json` in the **ProjectERP.Api** project and configure the connection string for your SQL Server instance:

    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Server=your-server;Database=ProjectERP;User Id=your-username;Password=your-password;"
    }
    ```

2. Apply database migrations:

    ```bash
    dotnet ef database update -p ProjectERP.Infrastructure -s ProjectERP.Api
    ```

This command will apply the initial migration and create the database schema based on your entities.

---


