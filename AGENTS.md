# AGENTS.md - LeaveManagementSystem

## Purpose

This repository is an ASP.NET Core MVC Leave Management System using EF Core, SQL Server

Agents must preserve the layered architecture and modernize toward .NET 10.

## Setup commands

Use these commands from the repository root;

```bash
dotnet --info
dotnet restore LeaveManagementSystem.sln
dotnet build LeaveManagementSystem.sln --configuration Release --no-restore
dotnet test LeaveManagementSystem.sln --configuration Release --no-build
