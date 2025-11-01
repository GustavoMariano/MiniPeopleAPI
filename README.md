# MiniPeopleAPI

A simple project built with **.NET 9 Minimal API**, created for learning and experimentation purposes.  
It demonstrates how to create endpoints, handle services, and use Swagger for API documentation in a lightweight setup.

---

## 🚀 Features

- **Login endpoint** with a simple static authentication  
- **CRUD-like endpoints** for managing people in memory  
- **Swagger UI** enabled for easy testing and exploration  

---

## 🧠 Purpose

This project was developed **only for educational purposes** — to understand how Minimal API works in .NET 9.  
It does not use a database, authentication provider, or external dependencies.

---

## 📂 Project Structure

```
MinimalAPI/
├── Program.cs
├── Endpoints/
│   ├── AuthEndpoints.cs
│   └── PeopleEndpoints.cs
├── Models/
│   └── Person.cs
└── Services/
    └── PersonService.cs
```

---

## 🧰 Requirements

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- Any IDE that supports C# (e.g., Visual Studio, VS Code, Rider)

---

## ▶️ How to Run

1. **Clone the repository:**
   ```bash
   git clone https://github.com/GustavoMariano/MiniPeopleAPI.git
   cd MiniPeopleAPI
   ```

2. **Run the application:**
   ```bash
   dotnet run
   ```

3. **Open Swagger UI:**
   ```
   https://localhost:5001/swagger
   ```

---

## 🔐 Authentication

To get a fake JWT token, use the `/login` endpoint.

**POST** `/login`

### Request Body
```json
{
  "username": "admin",
  "password": "123"
}
```

### Response
```json
{
  "token": "fake-jwt-token"
}
```

If the credentials do not match, the API will return `401 Unauthorized`.

---

## 👥 People Endpoints

| Method | Endpoint        | Description           |
|--------|-----------------|-----------------------|
| GET    | `/people`       | Returns all people    |
| POST   | `/people`       | Adds a new person     |
| GET    | `/people/{id}`  | Returns a person by ID |

### Example Person
```json
{
  "id": 1,
  "name": "John Doe",
  "age": 30,
  "profession": "Developer"
}
```

---

## 🧾 License

This project is open source and available under the **MIT License**.

---

## 💡 Author

Developed by **Gustavo Mariano** for learning purposes.
