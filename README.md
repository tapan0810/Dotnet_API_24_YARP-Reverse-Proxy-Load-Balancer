🚀 .NET YARP Reverse Proxy Load Balancer

A scalable ASP.NET Core Web API project demonstrating load balancing using YARP (Yet Another Reverse Proxy).

This project simulates a distributed backend architecture where multiple API instances handle requests through a central reverse proxy gateway, improving scalability, reliability, and system performance.

📌 Project Overview

This project demonstrates how to implement a load-balanced API system in ASP.NET Core using YARP Reverse Proxy.

The system consists of:

Gateway API using YARP Reverse Proxy

Multiple backend API instances

Shared SQL Server database

Entity Framework Core for data access

AutoMapper for DTO mapping

Incoming client requests are routed through the YARP Gateway, which distributes them across multiple backend services.

🏗️ System Architecture
            Client
              │
              ▼
       YARP Reverse Proxy
              │
      ┌───────────────┐
      │               │
      ▼               ▼
   API Instance 1   API Instance 2
    (Proxy_API_1)    (Proxy_API_2)
      │               │
      └────── Shared SQL Server ──────┘
🔄 Request Flow
Client Request
      │
      ▼
YARP Gateway
      │
      ▼
Load Balancing
   /       \
API 1     API 2
   \       /
   Shared Database

The gateway distributes requests between API instances to ensure balanced traffic handling and improved scalability.

🛠️ Technologies Used

ASP.NET Core Web API

YARP (Yet Another Reverse Proxy)

Entity Framework Core

SQL Server

AutoMapper

Dependency Injection

RESTful API Architecture

📂 Project Structure
Dotnet_API_24_YARP-Reverse-Proxy-Load-Balancer
│
├── Controllers        → API Controllers
├── Data               → Database Context
├── Entities           → Models and DTOs
├── Mapping            → AutoMapper Profiles
├── Migrations         → Entity Framework Migrations
├── Service            → Business Logic Layer
│
├── Proxy_API_1        → Backend API Instance 1
├── Proxy_API_2        → Backend API Instance 2
│
├── Program.cs         → Application Configuration
├── appsettings.json   → Configuration Settings
⚡ Key Features

Reverse Proxy implementation using YARP

Load balancing across multiple API instances

Shared SQL Server database

Clean architecture with Service Layer

DTO mapping using AutoMapper

Entity Framework Core integration

Pagination support for API responses

Scalable backend architecture

📡 API Endpoints
Get All Players (Pagination)
GET /api/players?pageNumber=1&pageSize=10
Get Player By Id
GET /api/players/{id}
Create Player
POST /api/players
Update Player
PUT /api/players/{id}
Delete Player
DELETE /api/players/{id}
▶️ Running the Project
1️⃣ Clone the Repository
git clone https://github.com/tapan0810/Dotnet_API_24_YARP-Reverse-Proxy-Load-Balancer.git
2️⃣ Open the Solution

Open the solution in Visual Studio

Dotnet_API_24_YARP-Reverse-Proxy-Load-Balancer.sln
3️⃣ Apply Database Migrations

Run:

dotnet ef database update

or using Visual Studio Package Manager Console:

Update-Database
4️⃣ Run the Applications

Start the following projects:

YARP Gateway API

Proxy_API_1

Proxy_API_2

The YARP Gateway will automatically distribute incoming requests between the backend APIs.

🔄 Example Load Balancing
Request 1 → Proxy_API_1
Request 2 → Proxy_API_2
Request 3 → Proxy_API_1
Request 4 → Proxy_API_2

This helps distribute traffic evenly across services.

📚 Learning Outcomes

This project demonstrates practical implementation of:

Reverse Proxy architecture

API Gateway pattern

Load balancing with YARP

Distributed backend systems

Clean layered architecture in ASP.NET Core

🔮 Future Improvements

Docker containerization

Kubernetes deployment

API rate limiting

Authentication and authorization

Logging and monitoring integration

👨‍💻 Author

Tapan Ray
Software Engineer | .NET Developer

GitHub:
https://github.com/tapan0810
