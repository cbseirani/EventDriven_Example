# Example .NET 8 Enterprise Event Driven Backend System
This is a mono-repo of a sample asynchronous n-tier system written with .NET 8 and C# using both SQL and MongoDb databases with a full suite of example enterprise features while following SOLID principals.

### Main REST API
  - `Swagger` documentation using in-code `XML` comments
  - Error-handling middleware
  - Fine-tuned logging to files and console using `Serilog` : https://serilog.net/
  - Customized `StyleCop` linting implementation : https://github.com/DotNetAnalyzers/StyleCopAnalyzers
  - `IoC` with `dependency injection` and `n-tier` pattern

### MongoDB database 
  - Website/API gathered content

### Sql Server Express database
  - Background thread settings and reporting 

### `Dockerfile` and `docker-compose.yml` files to stand up all resources locally
 
## TODO:
  - Logging to an ELK stack/logging cloud provider
  - Automated registering of DI services
  - Cache
  - Authentication with JWT
  - SignalR browser notifications
  - File Streaming Endpoint Example
  - Http request retry policies
  - Backend Thread/service examples
  - Thread throttling examples
  - 2 code-first gRPC microservices with pub/sub communication
  - OpenAI service integration
  - Unit tests with xUnit

## Running Locally

You'll need `Docker Compose` in order to use the `docker-compose.yml` file located in the root folder to deploy `BeatSheetService` and `MongoDB` in containers.
Get Docker Desktop: https://www.docker.com/products/docker-desktop/

1) open terminal and navigate to the root folder containing `EventDriven_Example.sln` and `docker-compose.yml`
2) run the command `docker-compose build mainapi`: