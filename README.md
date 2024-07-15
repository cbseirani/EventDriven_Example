# Example .NET 8 Event Driven Backend System
A sample asynchronous n-tier system written with .NET 8 and C# using both SQL and MongoDb databases.

- Main API
- Authentication with JWT
- Logging with Serilog
- Error Handling middleware
- SignalR browser notifications
- File Streaming Endpoint Example
- Http request retry policies
- Backend Thread/service example
- 2 code-first gRPC micro services with pub/sub communication
- MongoDB document db
- SQL db
- Dockerfile and docker-compose included


## Running Locally

You'll need `Docker Compose` in order to use the `docker-compose.yml` file located in the root folder to deploy `BeatSheetService` and `MongoDB` in containers.
Get Docker Desktop: https://www.docker.com/products/docker-desktop/

1) open terminal and navigate to the root folder containing `SampleApi.sln` and `docker-compose.yml`
2) run the command `docker-compose build sampleapi`:




