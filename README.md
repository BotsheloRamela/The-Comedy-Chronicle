# The Comedy Chronicle

The ASP.NET Core, The Comedy Chronicle, website is a simple web application built on ASP.NET Core framework with a database application written in C#. The primary purpose of this project is to allow users to enter jokes and their answers so that they can keep a record of their best humor.

This project is a basic CRUD application that uses MVC and SQL. It is an excellent starting point for beginners who want to learn ASP.NET Core framework and how to work with databases. The application has a simple user interface that allows users to create, read, update, and delete jokes.

The project uses Entity Framework Core to manage the database and to perform CRUD operations. It also uses ASP.NET Core Identity to manage user authentication and authorization. The project is built using the Model-View-Controller (MVC) pattern, which makes it easy to maintain and extend.

To run the application, you need to have .NET Core SDK installed on your computer. You also need to have Visual Studio Code or Visual Studio 2019 installed to open and run the project. Once you have the prerequisites installed, you can clone the repository and open the project in your IDE.

## Project Structure

The project structure follows the standard ASP.NET Core project structure:

- Controllers: Contains the controller classes that handle incoming HTTP requests.
- Data: Contains the database context class and the entity classes that represent the database tables.
- Models: Contains the view model classes that represent the data that is displayed in the views.
- Views: Contains the Razor view files that define the user interface of the application.
- wwwroot: Contains the static files that are served to the client-side of the application.
- appsettings.json: Contains the configuration settings for the application.

## Installation

To run this application on your local machine, follow the steps below:

1. Install the .NET Core SDK from <https://dotnet.microsoft.com/download>
2. Install an IDE like Visual Studio Code or Visual Studio 2019.
3. Clone the repository: `git clone https://github.com/BotsheloRamela/The-Comedy-Chronicle.git`
4. Open the project in your IDE.
5. Run the application by pressing F5 or by typing `dotnet run` in the terminal.

## Contributing

Contributions to this project are welcome. If you find any bugs or have any feature requests, please open an issue on the project's GitHub page.

## License

This project is licensed under the MIT License. You can find the license file in the project repository.
