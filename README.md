
---


```markdown
# GameStore Frontend

This is the frontend for the GameStore project, built with Blazor WebAssembly. It allows users to view and interact with games, including adding and editing them.

## Table of Contents
- [Installation](#installation)
- [Configuration](#configuration)
- [Running the Frontend](#running-the-frontend)
- [Connecting to the Backend](#connecting-to-the-backend)
- [Development](#development)

## Installation

```bash
1. Clone the repository:

   git clone https://github.com/yourusername/GameStore.Frontend.git

2.Navigate to the GameStore.Frontend directory:

    cd GameStore.Frontend

3.Restore the dependencies:

    dotnet restore

4.Build the project:

    dotnet build

5.Run the Blazor frontend:
    
    dotnet run

The frontend will start and be accessible at http://localhost:5099.


Configuration
Ensure that the GameStoreApiUrl in appsettings.json is set to the URL of the backend API (default: http://localhost:5160):

    Example configuration (appsettings.json):

            {
    "Logging": {
        "LogLevel": {
        "Default": "Information",
        "Microsoft.AspNetCore": "Warning"
        }
    },
    "GameStoreApiUrl": "http://localhost:5160",
    "AllowedHosts": "*"
    }

Running the Frontend
Once the frontend is running, it will make API requests to the backend. The Blazor application will load and display game information, allowing users to interact with the game data.

Connecting to the Backend
To ensure the frontend can communicate with the backend API, you must set the correct GameStoreApiUrl in the appsettings.json file of the frontend project.

    {
    "GameStoreApiUrl": "http://localhost:5160"
    }
