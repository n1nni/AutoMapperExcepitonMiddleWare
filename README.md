# BookMapperExcepitonMiddleWare

This is a sample ASP.NET Core web application that demonstrates the usage of AutoMapper and a custom exception middleware. The project provides a simple API for managing authors and books. It includes features like adding authors and books, fetching all authors, and handling custom exceptions.

## Technologies Used

- ASP.NET Core
- Entity Framework Core
- AutoMapper
- Custom Exception Middleware

## Project Structure

The project is organized into several components:

### Controllers

#### `AuthorController`

- Responsible for handling author-related HTTP requests.
- Provides endpoints for adding authors and fetching all authors.

#### `BookController`

- Manages book-related HTTP requests.
- Offers an endpoint for adding books.

### Data

#### `ApplicationDbContext`

- Represents the database context for the application.
- Includes DbSet properties for `Author` and `Book` entities.

### Mapping

#### `MappingProfile`

- Configures AutoMapper mappings between DTOs and entity models.

### Middlewares

#### `CustomExceptionMiddleware`

- A custom middleware for handling exceptions globally.
- Catches exceptions and returns custom JSON responses with status code 500.
- Provides a custom error message.

### Models

#### `Author` and `Book`

- Entity models representing authors and books.
- Includes properties and relationships with junction tables.

#### DTOs

- Data Transfer Objects (DTOs) for author and book entities.
- Used for data validation and communication with controllers.

#### `AuthorBook`

- Represents the junction table between authors and books.

### Repositories

#### `IAuthorRepository` and `IBookRepository`

- Interfaces defining the contract for author and book repositories.

#### `AuthorRepository` and `BookRepository`

- Implementations of the repository interfaces.
- Responsible for database operations related to authors and books.

## Getting Started

To run the application locally, make sure you have the following prerequisites:

- .NET SDK (compatible with C#)
- A C# development environment (e.g., Visual Studio, Visual Studio Code)

To use the Student Management app, follow these steps:

1. Clone this repository to your local machine using `git clone`.
2. Open the project in your preferred C# development environment (e.g., Visual Studio, Visual Studio Code).
3. Build and run the application.
   ```shell
   dotnet build
   dotnet run


## Contributing

Contributions to this project are welcome! If you find any issues or would like to enhance the application, feel free to create pull requests.

1. Fork the repository.
2. Create a new branch for your feature or fix.
3. Make your changes and test thoroughly.
4. Submit a pull request detailing your changes.

## Support, Contact and Author
This app was created by [n1nni](https://github.com/n1nni). If you encounter any issues, have suggestions for improvements, or need help with this project, feel free to reach out to me.

Contact Information:

:email: - Email: [nin.dautashvili@gmail.com](mailto:nin.dautashvili@gmail.com)

:email: - LinkedIn: [Nino Dautashvili](https://www.linkedin.com/in/nino-dautashvili/)

Thank you for checking out this project! :rocket:
