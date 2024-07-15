# Example .NET 8 Enterprise Event Driven Backend System
A sample asynchronous n-tier system written with .NET 8 and C# using both SQL and MongoDb databases.

- Presentation layer (Main REST API)
  - `Swagger` documentation using in-code `XML` comments
  - Error-handling middleware
  - Logging to files and console using `Serilog`
  - `IoC` with `dependency injection` and `n-tier` pattern
  - Dockerfile and docker-compose included

### TODO:
  - Logging to an ELK stack/logging cloud provider
  - Automated registering of DI services
  - Authentication with JWT
  - SignalR browser notifications
  - File Streaming Endpoint Example
  - Http request retry policies
  - Backend Thread/service examples
  - Thread throttling examples
  - 2 code-first gRPC microservices with pub/sub communication
  - MongoDB document db
  - SQL db
  - Unit tests with xUnit

## Running Locally

You'll need `Docker Compose` in order to use the `docker-compose.yml` file located in the root folder to deploy `BeatSheetService` and `MongoDB` in containers.
Get Docker Desktop: https://www.docker.com/products/docker-desktop/

1) open terminal and navigate to the root folder containing `EventDriven_Example.sln` and `docker-compose.yml`
2) run the command `docker-compose build mainapi`: