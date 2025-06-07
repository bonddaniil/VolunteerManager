# VolunteerDB

VolunteerDB is a desktop application developed as part of a course project to simulate the operation of a volunteer organization that assists with the reconstruction of damaged buildings. The project focuses on learning and applying object-oriented programming (OOP) principles and implementing various design patterns.

## Project Overview

The application allows users to manage volunteers, volunteer teams, buildings, and the process of volunteer work. It offers features for adding, editing, and deleting volunteers, teams, and buildings, as well as assigning teams to specific repair or construction tasks.

## Features

- Manage volunteer data (add, view, delete volunteers)
- Manage volunteer teams (add, view, delete teams)
- Manage buildings (add, view, delete buildings)
- Assign teams to specific buildings and tasks
- Simulate volunteer work on selected buildings
- Graphical user interface (GUI) built with WPF

## 🛠️ Design Patterns Used

- **Abstract Factory:** For creating families of related or dependent objects.
- **Builder:** For step-by-step construction of complex objects (buildings).
- **Prototype:** For cloning objects without depending on their concrete classes.
- **Factory Method:** For creating teams of different types and logic.
- **Decorator:** For dynamically adding functionality to volunteer objects.
- **Mediator:** For coordinating communication between multiple classes.
- **Template Method:** For defining the skeleton of algorithms and letting subclasses fill in the details.

##  Modular Structure

The system is divided into the following modules:

- **Main Menu Module:** Navigation between different application windows.
- **Volunteer Table Module:** Manages volunteer data.
- **Volunteer Team Table Module:** Manages team data.
- **Building Table Module:** Manages building data.
- **Volunteer Work Module:** Assigns teams to buildings and simulates repair or construction work.

##  Requirements

- Windows OS
- .NET Framework (or .NET Core)
- C# support in your development environment (e.g. Visual Studio)
- SQL Server (created using Microsoft SQL Management Studio)

## 💡 Getting Started

1. Clone the repository:
   ```bash
   git clone https://github.com/bonddaniil/VolunteerDB.git
