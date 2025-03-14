# MenuExercise

This project was developed as part of the course "**Object-Oriented Programming using the .NET Framework and C#**". The goal of the project was to demonstrate the implementation of object-oriented programming principles, such as **polymorphism**, **interfaces**, and **delegates**. 

The project is split into two separate sub-projects, both implementing the same menu system but with different techniques for educational purposes.

## Project Structure

The project consists of two separate implementations:

1. **Menu with Interfaces**:
   - This sub-project implements the menu system using **interfaces**. Each menu action is represented by a class that implements a specific interface, allowing for flexibility in adding new actions without changing existing code. The core idea is to demonstrate **polymorphism** where different implementations of an interface can be used interchangeably.

2. **Menu with Delegates**:
   - This sub-project uses **delegates** to link each menu action to a specific function. Delegates provide a more flexible and dynamic approach to assigning actions at runtime, allowing the program to execute functions based on user input or other conditions.

## Features

- **Polymorphism**: Both sub-projects demonstrate the use of polymorphism to handle different types of actions in the menu system without modifying existing code.
- **Interfaces**: The first implementation focuses on using interfaces to separate the behavior of different menu actions, promoting a clean and extensible codebase.
- **Delegates**: The second implementation utilizes delegates to dynamically assign functions to menu actions, offering a flexible alternative to interfaces.
- **Modular Design**: The system is designed in a modular way, making it easy to add or remove menu actions without impacting other parts of the system.
