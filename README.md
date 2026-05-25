# 🥖 Bakery Management API

A RESTful API for managing bakery orders, products, and pricing history.

Built with **ASP.NET Core 8**, **PostgreSQL**, and **Entity Framework Core**.

---

## 🛠 Tech Stack

- **Language:** C#
- **Framework:** ASP.NET Core 8 Web API
- **Database:** PostgreSQL + Entity Framework Core
- **Auth:** JWT Bearer Token
- **Password hashing:** BCrypt

---

## 📐 Database Schema

```mermaid
erDiagram
  Users {
    uuid Id PK
    string FullName
    string Email
    string PasswordHash
    string Role
    timestamp CreatedAt
  }
  Products {
    uuid Id PK
    string Name
    string Category
    boolean IsAvailable
    timestamp CreatedAt
  }
  PriceHistory {
    uuid Id PK
    uuid ProductId FK
    decimal Price
    timestamp EffectiveFrom
  }
  Orders {
    uuid Id PK
    uuid UserId FK
    string Status
    timestamp CreatedAt
    timestamp UpdatedAt
  }
  OrderStatusHistory {
    uuid Id PK
    uuid OrderId FK
    string Status
    timestamp ChangedAt
  }
  OrderItems {
    uuid Id PK
    uuid OrderId FK
    uuid ProductId FK
    decimal UnitPrice
    int Quantity
  }
  Users ||--o{ Orders : places
  Orders ||--|{ OrderItems : contains
  Orders ||--|{ OrderStatusHistory : tracks
  Products ||--|{ OrderItems : included_in
  Products ||--|{ PriceHistory : has
```

---

## 🚀 Features

- JWT authentication & authorization
- Product management with price history
- Order lifecycle tracking with status history
- Daily reports — top products, total revenue

---

## ⚙️ Getting Started

```bash
# Clone the repo
git clone https://github.com/TemurbekUbaydullayev/bakery-management-api.git

# Run migrations
dotnet ef database update

# Start the API
dotnet run
```