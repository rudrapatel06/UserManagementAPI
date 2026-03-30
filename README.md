# User Management API

## Project Purpose
The User Management API is designed to provide a simple and efficient means to manage user accounts and their associated data. The API allows for user registration, login, account management, and retrieval of user information, making it ideal for applications requiring user authentication and data storage.

## Local Setup Instructions
1. **Clone the repository**:
   ```bash
   git clone https://github.com/rudrapatel06/UserManagementAPI.git
   cd UserManagementAPI
   ```

2. **Install dependencies**:
   ```bash
   npm install
   ```

3. **Set up environment variables**: Create a `.env` file at the root of the project and configure your environment variables according to the `.env.example` file.

4. **Run the application**:
   ```bash
   npm start
   ```

5. **Access the API**: Open your browser and navigate to `http://localhost:3000` to access the API documentation or use tools like Postman.

## API Endpoints

### 1. User Registration
- **Endpoint**: `POST /api/users/register`
- **Request Body**:
   ```json
   {"username": "exampleUser", "password": "examplePass"}
   ```
- **Response**:
   ```json
   {"message": "User registered successfully!"}
   ```

### 2. User Login
- **Endpoint**: `POST /api/users/login`
- **Request Body**:
   ```json
   {"username": "exampleUser", "password": "examplePass"}
   ```
- **Response**:
   ```json
   {"token": "your_jwt_token_here"}
   ```

### 3. Get User Profile
- **Endpoint**: `GET /api/users/profile`
- **Headers**:
   ```json
   {"Authorization": "Bearer your_jwt_token_here"}
   ```
- **Response**:
   ```json
   {"username": "exampleUser", "createdAt": "2026-03-30T07:14:42Z"}
   ```

## Assistance from Copilot
During the development of this project, GitHub Copilot was instrumental in quickly generating boilerplate code, crafting endpoint definitions, and structuring the project. It helped in ensuring best practices were followed and provided suggestions for efficient coding, allowing for a streamlined development process.