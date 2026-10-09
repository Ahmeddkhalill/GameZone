# Game Management Portal

An ASP.NET Core MVC application for managing a catalog of games: create, view, edit, and delete games with cover images, categories, and the devices each game supports.

---

## Features

- **Full CRUD** for games with server-side validation.
- **Many-to-many relation** between games and devices (for example PlayStation, Xbox, Nintendo Switch, and PC).
- **Categories** selected from a dropdown.
- **Cover image upload** with custom validation attributes for allowed file extensions and maximum file size, plus client-side size checking.
- **Delete confirmation** with an AJAX request and a confirmation dialog.
- **Anti-forgery protection** on state-changing requests.
- **Service layer** behind interfaces with dependency injection.
- **Responsive UI** built with Bootstrap 5.

## Tech Stack

| Area | Technology |
|---|---|
| Framework | ASP.NET Core MVC, .NET 8 |
| Data | Entity Framework Core, SQL Server |
| Frontend | Razor views, Bootstrap 5, JavaScript |

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- SQL Server (LocalDB is fine)

### Run locally

```bash
git clone https://github.com/Ahmeddkhalill/GameZone.git
cd GameZone/GameZone

# update ConnectionStrings:DefaultConnection in appsettings.json for your SQL Server

dotnet ef database update
dotnet run
```

## Project Structure

```
GameZone/
├── Attributes/    Custom validation attributes for file extension and size
├── Controllers/   MVC controllers
├── Data/          DbContext and migrations
├── Models/        Game, Category, Device, and join entities
├── Services/      Business logic behind interfaces
├── Settings/      File upload settings
├── ViewModels/    Form and list view models
├── Views/         Razor views
└── wwwroot/       Static files, scripts, and uploaded images
```
