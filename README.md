# Insights Gateway Service

The Insights Gateway service is an API gateway that handles ad insights data and provides various endpoints for data retrieval and management.

## Prerequisites

- .NET 8.0 SDK
- IDE (Visual Studio, Rider, or VS Code)
- Git

## Project Structure 

Insights.Gateway/
├── Controllers/ # API Controllers
├── Services/ # Business Logic Services
├── Repositories/ # Data Access Layer
├── Properties/ # Contains launchSettings.json
└── Configuration/ # Configuration classes

## Getting Started

### Local Development Setup

1. Clone the repository:

## Configuration

The service uses the following configuration hierarchy:
- appsettings.json
- appsettings.Development.json (for development environment)
- Environment variables

## Dependencies

- Microsoft.AspNetCore.Mvc.Versioning.ApiExplorer
- Swashbuckle.AspNetCore
- Microsoft.AspNetCore.OpenApi

## Project References

- Insights.Service - Core business logic and service implementations

## Contributing

1. Create a feature branch
2. Make your changes
3. Submit a pull request

## Troubleshooting

If you encounter any issues:

1. Verify the environment is set correctly
2. Check the application logs
3. Ensure all dependencies are properly restored
4. Verify the port 5000 is not in use by another application
