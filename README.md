# UserManagementAPI

## 📌 Overview
UserManagementAPI is a lightweight ASP.NET Core Web API designed for managing user records. It supports full CRUD operations, input validation, and includes custom middleware for logging request performance. This project demonstrates back-end development fundamentals and the use of Microsoft Copilot to scaffold, debug, and enhance code.

---

## 🚀 Features
- **CRUD Endpoints**
  - GET `/api/users` → Retrieve all users
  - GET `/api/users/{id}` → Retrieve a user by ID
  - POST `/api/users` → Add a new user (validated)
  - PUT `/api/users/{id}` → Update an existing user
  - DELETE `/api/users/{id}` → Remove a user by ID

- **Validation**
  - Ensures only valid user data is processed using DataAnnotations:
    - `[Required]` for mandatory fields
    - `[EmailAddress]` for email format
    - `[StringLength]` for name length

- **Middleware**
  - Custom logging middleware measures and logs the time taken to process each request.

---

## 🧑‍💻 Copilot Contributions
Microsoft Copilot assisted throughout the project:
- **Scaffolding:** Generated boilerplate code in `Program.cs` to set up controllers and middleware quickly.
- **CRUD Endpoints:** Helped scaffold `UsersController` with proper HTTP responses (`Ok`, `NotFound`, `CreatedAtAction`, `NoContent`).
- **Validation:** Suggested DataAnnotations for the `User` model to enforce valid input.
- **Debugging:** Assisted in fixing null reference issues and improved error handling with `BadRequest(ModelState)`.
- **Middleware:** Generated a custom logging middleware and guided integration into the pipeline.
- **Testing:** Provided a Postman collection JSON to automate endpoint testing.

---

## 🧪 Testing
A Postman collection is included for automated testing:

- File: `Tests/UserManagementAPI.postman_collection.json`
- Import into Postman and run the collection to test all CRUD endpoints.

Example request body for **POST /api/users**:
```json
{
  "name": "John Doe",
  "email": "john@example.com",
  "department": "HR"
}
