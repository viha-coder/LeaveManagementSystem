# Leave Management System (.NET / ASP.NET Core)

> **Work in Progress:** This project is currently under active development.

An enterprise web application built with **ASP.NET Core MVC** designed to streamline employee leave requests, approval workflows, and leave allocation management.

---

### Features

- [x] **Project Setup & MVC Architecture:** Clean separation of concerns with Controllers, Views, and Data Models.
- [x] **Entity Framework Core Integration:** Database context and initial entity design.
- [ ] **Authentication & Authorization (Identity):** Role-based access for Employees and Administrators.
- [ ] **Leave Request Workflow:** Employees submit leave applications with status tracking (Pending, Approved, Rejected).
- [ ] **Admin Dashboard:** Overview of pending requests, approval actions, and employee leave balances.
- [ ] **Email Notifications:** Automated alerts upon request updates.

---

### Tech Stack & Tools

- **Language:** C#
- **Framework:** ASP.NET Core MVC
- **Data Access:** Entity Framework Core & SQL Server (LocalDB)
- **UI / Frontend:** Razor Views (`.cshtml`), HTML5, CSS3, Bootstrap
- **Tools:** Visual Studio / VS Code, Git, GitHub

---

### Getting Started

#### Prerequisites
- .NET 8 SDK (or latest .NET SDK)
- SQL Server LocalDB or standard SQL Server instance

#### Installation & Run
1. Clone the repository:
   git clone https://github.com/viha-coder/LeaveManagementSystem.git
   cd LeaveManagementSystem

2. Update Database (Migrations):
   dotnet ef database update

3. Run the project:
   dotnet run

---

### Roadmap

- [ ] Implement Identity for User Roles (Admin vs. Employee).
- [ ] Build CRUD operations for Leave Types and Allocations.
- [ ] Implement Request Validation and Business Rules.
- [ ] Improve UI/UX with responsive dashboard controls.

---

### Author

**Guilherme Medeiros**  
Software Analysis and Development Student  
-  LinkedIn: https://www.linkedin.com/in/guilherme-medeiros-b4a26520a
-  Email: guilhermemedeiros2233@gmail.com
