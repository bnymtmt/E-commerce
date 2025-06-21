# MultiShop - Microservices Based E-Commerce Platform

Welcome to **MultiShop**, a full-featured microservices-based e-commerce application that I developed from scratch using **ASP.NET Core** and a wide range of modern technologies.

This project represents a realistic and modular architecture, where each domain (catalog, basket, order, identity, etc.) is developed and deployed as an independent microservice. Throughout the project, I applied best practices in backend development, security, and DevOps.

## 🚀 What I Built

I designed and implemented this project from the ground up in a clean solution structure, focusing on **modularity, scalability, and real-world use cases**. The goal was to simulate a real e-commerce experience, with separate authorization flows for **admin**, **user**, and **guest** roles.

The backend consists of several independently running microservices communicating via HTTP and asynchronous messaging, containerized using **Docker**. I integrated multiple data storage technologies and designed secure APIs using **JWT Bearer Tokens** and **IdentityServer4**.

## 🧩 Technologies Used

- **ASP.NET Core Web API**
- **Microservices Architecture**
- **Docker & Docker Compose**
- **Redis**
- **MongoDB**
- **PostgreSQL**
- **MSSQL**
- **SQLite**
- **Dapper & Entity Framework**
- **Google Drive Image Upload Integration**
- **IdentityServer4 (OAuth2 & OpenID Connect)**
- **API Gateway with Ocelot**
- **JWT Authentication & Authorization**
- **CQRS Pattern**
- **Mediator Pattern (MediatR)**
- **Repository Pattern**
- **Swagger API Documentation**
- **SignalR** for real-time messaging
- **Postman Collections** for testing
- **Onion Architecture**
- **Ajax** interactions
- **RapidAPI integrations**

## 🔐 Role-Based Access

Each type of user in the system experiences a different set of functionalities:
- **Admin**: Full access to manage products, users, orders, etc.
- **User**: Purchase products, manage basket, view orders.
- **Guest**: Can browse the store with limited access.

## 📦 Services (Microservice Domains)

- **Catalog Service** – Product management
- **Basket Service** – Shopping cart management with Redis
- **Order Service** – Order placement and tracking
- **Identity Service** – Authentication, role management (via IdentityServer)
- **Photo Stock Service** – Upload and manage images (integrated with Google Drive)
- **Gateway Service** – Routing and authentication control via Ocelot
- **Discount, Payment, and Notification Services** (optional extensions)

## 💡 What I Learned

- How to build scalable .NET microservices with secure communication
- Deep integration of **IdentityServer** for custom authentication flows
- Effective use of multiple databases in a single project (SQL + NoSQL)
- Hands-on containerization and service orchestration with **Docker**
- Applying **CQRS**, **MediatR**, and **Repository Pattern** for clean codebase
- Real-world API documentation and testing via Swagger and Postman
- How to develop a project end-to-end and publish it to a live environment

## 📌 Final Thoughts

This project helped me consolidate and apply what I’ve learned in enterprise-level .NET development. It's ideal for anyone looking to explore **microservices**, **API security**, and **multi-database integrations** in .NET.

---

Thanks for checking out my project!

Feel free to clone, fork, or contribute ✌  
