# Transcendent Test README

This README file provides instructions for installing and running the Transcendent Test .NET project, it utilizes a PostgreSQL database.

## Prerequisites

Before you begin, ensure you have the following prerequisites installed on your system:

- [.NET SDK](https://dotnet.microsoft.com/download)
- [PostgreSQL](https://www.postgresql.org/download/)

## Installation

1. **Clone the Repository**:

    ```shell
    git clone https://github.com/ssdev4/transcendent-test.git
    cd transcendent-test
    ```

2. **Database Setup**:

    - Create a PostgreSQL database for your project.

3. **Connection String Configuration**:

    Open the `appsettings.json` file in your project directory and configure/update the database connection string:

    ```json
    "ConnectionStrings": {
        "DefaultConnection": "YourConnectionStringHere"
    }
    ```

4. **Run Migrations**:

    To create the database schema, run the following commands in your project directory:

    ```shell
    dotnet ef database update
    ```

5. **Build and Run the Application**:

    In your project directory, execute the following commands:

    ```shell
    dotnet build
    dotnet run
    ```

    This will build the project and start the application. It will be accessible at `http://localhost:5000` by default.

## Usage

Enter the number and you will see the result ie n*2 and (n*2)^2 and it will also saved in DB.
