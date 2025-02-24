# Insights Gateway Service

The Insights Gateway service is an API gateway that handles ad insights data and provides various endpoints for data retrieval and management.

## Prerequisites

- .NET 8.0 SDK
- IDE (Visual Studio, Rider, or VS Code)
- Git

## Project Structure 

<img width="413" alt="image" src="https://github.com/user-attachments/assets/436798bb-08c1-4c50-90a3-f570c7c75138" />


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

## Troubleshooting

If you encounter any issues:

1. Verify the environment is set correctly
2. Ensure all dependencies are properly restored
3. Verify the port 5000 is not in use by another application
