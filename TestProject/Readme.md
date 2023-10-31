# TestProject - ASP.NET Core Project

TestProject is an ASP.NET Core project that allows users to input a number, calculates its square, and stores the data in a PostgreSQL database. It provides a user-friendly interface for number calculations.

## Features

- Input a number and see its multiple of 2 and whole square.
- Store number entries in a PostgreSQL database.
- Display all stored entries on the home page.
- Add new entries with a user-friendly form.

## Prerequisites

- .NET 6 SDK
- Visual Studio, Visual Studio Code, or any code editor of your choice.
- PostgreSQL database server.

## Getting Started

### Clone the repository to your local machine:
    git clone https://github.com/yourusername/TestProject.git

### Install dependanies on your local machine:
    MicrosoftEntityFramework
    MicrosoftEntityFramework.design
    Npgsql.MicrosoftEntityFramework.postgreSQL
    Moq

### Update DataBase
    for update database run the command  ```dotnet ef database update```


### Configration
    Connection string will be in appsettings.json

### Build the Application
    to build the application run the command ```dotnet build```

