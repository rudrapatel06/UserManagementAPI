# UserManagementAPI

## 📌 Overview
A simple ASP.NET Core Web API for managing users. Supports CRUD operations with validation and logging middleware.

## 🚀 Endpoints
- GET `/api/users` → List all users
- GET `/api/users/{id}` → Get user by ID
- POST `/api/users` → Add new user (validated)
- PUT `/api/users/{id}` → Update user
- DELETE `/api/users/{id}` → Remove user

## 🔒 Middleware
- Custom logging middleware measures request duration.

## 🛠 Copilot Contributions
- Scaffolded Program.cs boilerplate
- Generated CRUD endpoints
- Suggested validation attributes
- Helped debug null reference issues
- Added `CreatedAtAction` for POST responses

## 🧪 Testing
Import `Tests/UserManagementAPI.postman_collection.json` into Postman to test all CRUD endpoints automatically.


## ▶️ Run Locally
```bash
dotnet build
dotnet run
