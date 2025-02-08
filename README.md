# fiap_fase1_techChanllenge

## Contact Management API

A .NET Core Web API project that provides endpoints to manage contacts with Brazilian DDD (Direct Distance Dialing) codes.

## Preentation Video
[Presentation Video](https://youtu.be/JlzNH6JLJXY)

## Technologies Used

- .NET 8.0
- Entity Framework Core 8.0
- SQL Server
- xUnit (for unit testing)
- Swagger/OpenAPI
- In-Memory Database (for testing)

## Project Structure

The solution follows a clean architecture pattern with the following projects:

1. **01_WebApi**: API endpoints and configuration
2. **02_Application**: Application services and view models
3. **03_Core**: Core domain entities and interfaces
4. **04_Infrastructure**: Data access and repository implementations
5. **05_UnitTest**: Unit tests for the application

## Features

- CRUD operations for contacts
- DDD (Direct Distance Dialing) validation
- In-memory caching
- Input validation
- Error handling with custom response models
- Database seeding with Brazilian DDD codes
- Comprehensive unit tests

## Database Schema

### Contact Table
- Id (Primary Key)
- Name (varchar(100))
- Phone (varchar(20))
- Email (varchar(255))
- DddId (Foreign Key)
- CreatedOn (DateTime2)

### DirectDistanceDialing Table
- Id (Primary Key)
- Region (varchar(50))
- CreatedOn (DateTime2)

## Getting Started

### Prerequisites

- .NET 8.0 SDK
- SQL Server
- Visual Studio 2022 or VS Code

### Configuration

1. Update the connection string in `appsettings.json`:
```json
"ConnectionStrings": {
"DefaultConnection": "Server=YOUR_SERVER; Database=Fase1TechChallenge; Persist Security Info=False; Trusted_Connection=True; TrustServerCertificate=True"
}
```

2. Run the Entity Framework migrations:
```bash
Update-Database -Project 04_Infraestructure -StartupProject 04_Infraestructure
```

### Running the Application

1. Clone the repository
2. Update the connection string
3. Run Entity Framework migrations:
```bash
Update-Database -Project 04_Infraestructure -StartupProject 04_Infraestructure
```
4. Run the application:
```bash
dotnet run --project 01_WebApi
```

The API will be available at:
- HTTP: http://localhost:5181
- HTTPS: https://localhost:7251

Swagger documentation will be available at `/swagger`

## API Endpoints

### Contacts
- GET `/api/v1/contacts` - Get all contacts
- GET `/api/v1/contacts/{id}` - Get contact by ID
- POST `/api/v1/contacts` - Create new contact
- PUT `/api/v1/contacts/{id}` - Update existing contact
- DELETE `/api/v1/contacts/{id}` - Delete contact

### Input Validation

Contact creation/update requires:
- Name: 1-100 characters
- Phone: Valid format (XXXX-XXXX or XXXXX-XXXX)
- Email: Valid email format
- DddId: Valid Brazilian DDD code (11-99)



## Error Handling

The API uses a standardized error response format:
```json
{
    "success": false,
    "message": "Error message",
    "data": null
}
```

## Testing

Run the unit tests:

```bash
dotnet test
```

## License

This project is licensed under the MIT License.
