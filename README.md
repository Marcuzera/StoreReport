# Sales & Stock – C# Development Training

## Overview

The **Sales & Stock** project is a practical C# development exercise designed to strengthen fundamental software engineering skills through hands-on implementation.

The application processes a provided XML file (`Sales_Stock.xml`) containing product, sales, and inventory information.

The primary objective is not simply to deliver a working application, but to consolidate programming fundamentals, encourage independent problem-solving, and develop good software engineering practices.

The project also provides a consistent foundation for technical mentoring, code reviews, and evaluating each developer's progress over time.

---

## Learning Objectives

### Programming Fundamentals

Develop a strong understanding of programming logic and problem-solving techniques.

Key concepts include:

- Variables, data types, and operators
- Conditional statements (`if`, `else`, `switch`)
- Iteration structures (`for`, `foreach`, `while`)
- Methods, parameters, and return values
- Collections and data manipulation
- Logical reasoning and algorithm development
- Breaking complex problems into smaller responsibilities

Developers should prioritize understanding and implementing solutions through programming logic rather than relying exclusively on built-in query methods.

### Object-Oriented Programming (OOP)

Apply object-oriented principles to organize the application into reusable and maintainable components.

Concepts to practice:

- Classes and objects
- Encapsulation
- Abstraction
- Inheritance and polymorphism, where appropriate
- Interfaces and contracts
- Separation of concerns
- Dependency injection
- Responsibility distribution between components

### Software Engineering Best Practices

Develop familiarity with established development principles and practices.

**SOLID Principles**
- Single Responsibility Principle (SRP)
- Open/Closed Principle (OCP)
- Liskov Substitution Principle (LSP)
- Interface Segregation Principle (ISP)
- Dependency Inversion Principle (DIP)

**Clean Code**
- Meaningful naming conventions
- Small and focused methods
- Avoiding unnecessary complexity
- Reducing code duplication
- Maintaining consistent formatting
- Writing readable and maintainable code

**Documentation**
- Proper usage of XML documentation (`<summary>`)
- Clear descriptions of public methods and responsibilities
- Documentation focused on explaining behavior and intent

---

## Technologies

- **Language:** C#
- **Platform:** .NET
- **Data Source:** XML (`Sales_Stock.xml`)
- **Testing Framework:** NUnit
- **Mocking Framework:** Moq

---

## Project Structure

The application should follow a layered architecture, with components organized according to their responsibilities.

```text
SalesStockAnalyzer/
├── Domain/
├── Services/
├── Interfaces/
├── Infrastructure/
└── Tests/
```

Developers should understand the purpose of each layer and maintain clear separation between business logic, data access, and application behavior.

---

## Functional Requirements

The application must read and process the provided `Sales_Stock.xml` file and expose the following functionalities through a console menu.

### Menu Options

1. Quantity of products in stock
2. Total sales value of products in stock
3. Best-selling product
4. Most profitable product
5. Products that have not been sold
6. Out-of-stock products
7. Execute all options
0. Exit

Each functionality should be implemented with clearly defined responsibilities, avoiding unnecessary coupling between components.

Business calculations and data processing should be separated from console input and output.

---

## Unit Testing

Unit testing is an essential part of the development exercise and should be implemented alongside the application functionalities.

### Required Concepts

- NUnit testing framework
- AAA Pattern (Arrange, Act, Assert)
- Mocking dependencies with Moq
- Using `MockRepository`
- Strict mocking with `MockBehavior.Strict`
- Verifying expected method calls and interactions
- Testing expected results and business behavior

### Testing Expectations

Developers are expected to:

- Create unit tests for business logic and service classes
- Cover successful and unsuccessful scenarios
- Test boundary conditions and edge cases
- Validate behavior with empty or inconsistent data
- Keep tests readable, independent, and deterministic
- Understand the purpose of each assertion and mock configuration

Unit tests should verify application behavior rather than simply increase test coverage.

---

## Validation and Error Handling

The application should handle unexpected situations in a predictable and maintainable way.

Scenarios to consider include:

- Missing or invalid XML files
- Malformed XML content
- Null or missing product information
- Negative quantities or prices
- Inconsistent sales and stock information
- Duplicated products
- Unexpected exceptions during processing

Developers should implement validation rules based on the application's expected behavior and clearly separate business validation from technical exception handling.

---

## Artificial Intelligence Usage

Artificial Intelligence is permitted as a learning and productivity support tool.

However, developers are expected to understand, explain, and justify their own implementations.

### Recommended Usage

- Clarifying programming concepts
- Understanding errors and exceptions
- Reviewing code readability
- Exploring alternative approaches
- Improving technical documentation
- Discussing architectural decisions

### Practices to Avoid

- Generating complete implementations without understanding them
- Copying solutions without reviewing their behavior
- Relying on AI instead of practicing programming logic
- Accepting generated code without validation
- Using AI to bypass problem-solving activities

**The goal is to develop technical independence, not dependency on AI-generated solutions.**

---

## Mentoring and Code Reviews

The project will be used as a practical reference during mentoring sessions and recurring code reviews.

Code reviews should focus on both the implementation and the developer's reasoning.

### Evaluation Criteria

**Programming Logic**
- Ability to independently develop algorithms
- Correct use of control flow and collections
- Understanding of the implemented calculations

**Code Quality**
- Readability and naming conventions
- Appropriate method and class responsibilities
- Application of Clean Code principles

**Object-Oriented Design**
- Proper use of abstraction and encapsulation
- Appropriate use of interfaces
- Separation of responsibilities
- Understanding of SOLID principles

**Unit Testing**
- Quality and relevance of test scenarios
- Understanding of mocking and dependency isolation
- Ability to identify edge cases

**Technical Autonomy**
- Ability to investigate and resolve problems
- Understanding of implemented solutions
- Ability to explain technical decisions
- Openness to feedback and continuous improvement

The evaluation process should prioritize demonstrated understanding, technical growth, and the ability to apply concepts independently.

---

## Expected Outcomes

By completing this project, developers should be able to:

- Build a functional C# console application
- Read and manipulate structured XML data
- Implement business logic using fundamental programming concepts
- Organize code using object-oriented design
- Apply SOLID and Clean Code principles
- Write meaningful unit tests using NUnit and Moq
- Handle invalid data and unexpected situations
- Explain and defend their technical decisions
- Participate effectively in technical discussions and code reviews

---

## Final Considerations

**Sales & Stock is a learning-oriented project, not a production application.**

Its purpose is to provide a practical environment where developers can consolidate theoretical knowledge, improve coding skills, and develop confidence in their technical decisions.

More important than completing every functionality is understanding how and why each solution works.

The project also establishes a consistent technical baseline for mentorship, allowing progress to be evaluated through code quality, reasoning, testing practices, and increasing autonomy.