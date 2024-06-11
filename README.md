# CDN - Complete-Developer-Network

This is a RESTful API project built using ASP.NET Core Web API to manage a directory of freelancers for the CDN - Complete Developer Network.

## Table of Contents
- [Introduction](#introduction)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [API Endpoints](#api-endpoints)
  - [User Endpoints](#user-endpoints)
- [Database Integration](#database-integration)
- [Additional Features](#additional-features)
  - [Securing the Endpoint](#securing-the-endpoint)
  - [Caching Strategy](#caching-strategy)
  - [Pagination](#pagination)
  - [Error Handling](#error-handling)
  - [Testing Strategy](#testing-strategy)
  - [CI/CD](#ci-cd)
- [Design Pattern](#design-pattern)
- [Demonstration](#demonstration)
- [Contributing](#contributing)
- [License](#license)

## Introduction
The CDN - Complete Developer Network project aims to provide a directory of freelancers that can be used by themselves to find and hire the right talent for their projects. This RESTful API allows users to register, update, delete, and retrieve information about freelancers.

## Features
- Register a new freelancer
- Update an existing freelancer's details
- Delete a freelancer from the system
- Retrieve a list of all registered freelancers
- Retrieve details of a specific freelancer

## Technologies Used
- ASP.NET Core Web API
- Entity Framework Core
- MySQL 
- Swagger for API documentation
- Azure DevOps for CI/CD

## Getting Started

### Prerequisites
- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [MySQL](https://www.mysql.com/downloads/) (or any other RDBMS of your choice)
- [Redis](https://redis.io/download) (optional, for caching strategy)

### Installation
1. Clone the repository:
   ```
   git clone https://github.com/your-username/cdn-developer-network.git
   ```
2. Navigate to the project directory:
   ```
   cd cdn-developer-network
   ```
3. Restore the project dependencies:
   ```
   dotnet restore
   ```
4. Update the database connection string in the `appsettings.json` file.
5. Apply the database migrations:
   ```
   dotnet ef database update
   ```
6. Run the application:
   ```
   dotnet run
   ```
7. The API will be available at `https://localhost:5001/api/v1/users`.

## API Endpoints

### User Endpoints
- `GET /api/v1/users`: Retrieve a list of all registered freelancers.
- `GET /api/v1/users/{id}`: Retrieve details of a specific freelancer.
- `POST /api/v1/users`: Register a new freelancer.
- `PUT /api/v1/users/{id}`: Update an existing freelancer's details.
- `DELETE /api/v1/users/{id}`: Delete a freelancer from the system.

## Database Integration
The project uses Entity Framework Core to interact with the MySQL (or any other RDBMS) database. The `UserDbContext` class is responsible for managing the `User` entity and its mapping to the database.

## Additional Features

### Securing the Endpoint
The API endpoints are secured using JWT (JSON Web Tokens) for authentication and authorization.

### Caching Strategy
The project implements a caching strategy using Redis (or any other caching solution) to improve the performance of the API.

### Pagination
The "Get All Users" endpoint supports pagination to handle large datasets efficiently.

### Error Handling
The project has a robust error handling mechanism to provide meaningful and informative responses to the client in case of errors.

### Testing Strategy
The project includes unit tests and integration tests to ensure the reliability and correctness of the API.

### CI/CD
The project uses Azure DevOps (or any other CI/CD tool) to set up a continuous integration and continuous deployment pipeline.

## Design Pattern
The project follows the Clean Architecture or the CQRS (Command Query Responsibility Segregation) pattern to ensure maintainability and scalability.

## Demonstration
During the interview session, I will demonstrate the functionality of the API, including querying data, adding data, updating data, and removing data.

## Contributing
If you would like to contribute to this project, please feel free to submit a pull request or open an issue.

## License
This project is licensed under the [MIT License](LICENSE).
