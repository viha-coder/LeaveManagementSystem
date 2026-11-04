# Leave Management System (.NET 10 / ASP.NET Core MVC)

> 🚀 **Work in Progress:** Enterprise web application under active development to build a robust platform for employee leave management.

An enterprise web application built with **ASP.NET Core MVC** designed to streamline employee leave requests, approval workflows, and leave allocation management.

### Key Features & Current Progress

* \[x\] **Architecture & Pattern (MVC):** Strict separation of concerns using Controllers, Razor Views, and Data Models.

* \[x\] **Data Access Layer:** Integrated Entity Framework Core with SQL Server migrations.

* \[x\] **DTO / ViewModel Pattern:** Clean architecture separating Database Entities (`LeaveType`) from UI Presentation Models (`IndexVM`, `LeaveTypeReadOnlyVM`) to prevent over-posting and protect internal data.

* \[x\] **Object Mapping:** Configured **AutoMapper 16.x** profiles for seamless entity-to-viewmodel transformations.

* \[x\] **Validation & Security:**

  * Robust form validations using **Data Annotations** (`[Required]`, `[Range]`, `[Display]`) and `ModelState` inspection.

  * Implemented **Custom Validation Rules** for complex domain logic.

  * Secured local configuration parameters and license keys using **.NET User Secrets** to keep sensitive data out of source control.

* \[x\] **Complete CRUD for Leave Types:** Full administrative workflows for creating, reading, updating, and deleting leave types.

* \[ \] **Authentication & Authorization (ASP.NET Core Identity):** Role-based access control for Employees and Administrators.

* \[ \] **Leave Request Workflow:** Submission, approval, rejection, and tracking logic for leave requests.

* \[ \] **AI Integration:** Smart analysis of leave justification text and automated policy checks using Generative AI APIs.

### Tech Stack & Tools

* **Language:** C# 13 / .NET 10

* **Framework:** ASP.NET Core MVC

* **Data & Mapping:** Entity Framework Core, AutoMapper 16.x, SQL Server

* **Security:** .NET User Secrets

* **UI / Frontend:** Razor Views (`.cshtml`), HTML5, CSS3, Bootstrap 5

* **IDE & Tools:** Visual Studio 2022, Git, GitHub

### Project Structure Highlights

LeaveManagementSystem/
├── Controllers/         # Handles HTTP requests and business flow
├── Data/                # DbContext, Migrations, and Database Entities
├── Mapping/             # AutoMapper profiles (MappingProfile.cs)
├── Models/
│   └── LeaveTypes/      # Form ViewModels & ReadOnly ViewModels
└── Views/
└── LeaveTypes/      # Razor Views bound to ViewModels

### Getting Started

#### Prerequisites

* .NET 10 SDK

* SQL Server LocalDB or full SQL Server instance

#### Setup & Run Locally

1. Clone the repository:
   git clone https://github.com/viha-coder/LeaveManagementSystem.git
   cd LeaveManagementSystem

2. Configure User Secrets (Optional for extended services):
   dotnet user-secrets init

3. Apply Database Migrations:
   dotnet ef database update

4. Run the Application:
   dotnet run

### Author

**Guilherme Medeiros**

Software Analysis and Development Student | ASP.NET Core Developer

* **LinkedIn:** https://www.linkedin.com/in/guilherme-medeiros-b4a26520a

* **GitHub:** https://github.com/viha-coder
