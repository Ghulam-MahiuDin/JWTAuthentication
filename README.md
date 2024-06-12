# JwtAuthApi

This project is an ASP.NET Core 7 Web API that uses JSON Web Token (JWT) for authentication. It includes endpoints for user login and accessing protected data.

## Getting Started

### Prerequisites

- [.NET 7 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)

### Setup

1. **Clone the repository:**

    ```bash
    git clone https://github.com/yourusername/JwtAuthApi.git
    cd JwtAuthApi
    ```

2. **Restore dependencies:**

    ```bash
    dotnet restore
    ```

3. **Update `appsettings.json`:**

    Ensure the `appsettings.json` file contains your JWT settings:

    ```json
    {
      "Logging": {
        "LogLevel": {
          "Default": "Information",
          "Microsoft.AspNetCore": "Warning"
        }
      },
      "AllowedHosts": "*",
      "Jwt": {
        "Key": "your_secret_key_here",
        "Issuer": "yourdomain.com",
        "Audience": "yourdomain.com"
      }
    }
    ```

4. **Run the project:**

    ```bash
    dotnet run
    ```

## Usage

### Authentication

To authenticate a user and receive a JWT token, send a POST request to the `/api/auth/login` endpoint with the following JSON body:

```json
{
  "username": "test",
  "password": "password"
}
