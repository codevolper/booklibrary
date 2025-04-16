# BookLibrary Application

## Overview
This application is a Book Library API built with .NET 8 and uses SQL Server as the database. The application is containerized using Docker.

## Prerequisites
- Docker installed on your machine
- Docker Compose installed on your machine

## Getting Started

### 1. Clone the Repository
```
git clone <repository-url> cd <repository-directory>
```

### 2. Build and Run the Containers
Use Docker Compose to build and run the containers.
```
docker-compose up --build
```
This command will:
- Build the `booklibrary-webapi` image.
- Start the `BookLibrary.WebApi` container.
- Start the `BookLibrary.DB` container with SQL Server.
- Run the `init.sql` script to initialize the database.

### 3. Verify the Containers are Running
You can verify that the containers are running by using the following command:
```
docker ps
```
You should see two containers: `BookLibrary.WebApi` and `BookLibrary.DB`.

## Testing the Application

### 1. Access the API
The API will be accessible at `http://localhost:8080` or `http://localhost:8081`.

### 2. Test Endpoints
You can use tools like Postman or cURL to test the API endpoints. For example, to test the `SearchBooks` endpoint, you can use the following cURL command:
```
curl -X POST "http://localhost:8080/api/books/search" -H "Content-Type: application/json" -d '{"Title": "Sample Book", "ISBN": "1234567890"}'
```
### 3. Check Database
You can connect to the SQL Server database using any SQL client with the following connection details:
- Server: `localhost`
- Port: `1433`
- User: `sa`
- Password: `SqlDevP@ss`
- Database: `booklibrary_db`

## Stopping the Containers
To stop the containers, use the following command:
```
docker-compose down
```
This will stop and remove the containers.

## Additional Information
- Ensure that the `init.sql` file is in the same directory as the `docker-compose.yml` file.
- The `init.sql` script creates the `booklibrary_db` database, a `Books` table, and inserts a sample record.

## Troubleshooting
- If the containers do not start, check the Docker logs for any errors.
- Ensure that the ports `8080`, `8081`, and `1433` are not being used by other applications.
