# NES Software Design Document (SDD)

## Version 1.0

## 1. Introduction

This document describes the software design of the Nutrition Evaluation System (NES).

It defines the architectural structure, components, responsibilities, and design decisions that guide the implementation of the system.

---

## 2. System Architecture

NES follows a layered architecture based on Domain Driven Design (DDD).

The main layers are:

- Domain Layer
- Application Layer
- Infrastructure Layer
- API Layer

---

## 3. Domain Layer

The Domain Layer represents the core business logic of NES.

It contains:

- Patient Aggregate
- Visit Aggregate
- DietPlan Aggregate
- Business Rules
- Domain Entities
- Value Objects

---

## 4. Application Layer

The Application Layer manages application workflows and use cases.

Responsibilities:

- Commands
- Queries
- Services
- DTO Mapping
- Validation

---

## 5. Infrastructure Layer

The Infrastructure Layer provides technical implementations.

Responsibilities:

- Database Access
- Entity Framework Core
- File Storage
- Authentication
- External Services

---

## 6. API Layer

The API Layer exposes system functionality through REST APIs.

Responsibilities:

- Controllers
- Authentication Endpoints
- Request Handling
- Response Formatting

---

## 7. Design Principles

NES follows:

- Clean Architecture
- Domain Driven Design
- Separation of Concerns
- Maintainability
- Scalability
