# NES Architecture & Coding Standards v1.0

## Status

Approved

## Version

1.0

## Purpose

This document defines the official coding and architectural standards for the NES project.

It establishes the rules that guide software design, naming conventions, project structure, and development practices.

---

# Core Principles

## 1. Business First

The code must represent business rules before technical details.

The system design should reflect NES business needs and workflows.

---

## 2. Domain Is King

The Domain layer is the heart of the system.

Business concepts, rules, and entities belong to the Domain layer.

---

## 3. Explicit Is Better Than Implicit

Clear naming is preferred over short naming.

Names should explain their purpose and avoid ambiguity.

---

## 4. Single Responsibility Principle

Each class has one responsibility.

A component should have one reason to change.

---

## 5. Rich Domain Model

The Domain contains both data and behavior.

Entities should protect their own rules and maintain consistency.

---

## 6. Clean Architecture

Dependencies must point toward the Domain.

The Domain must not depend on external frameworks.

---

## 7. Separation of Concerns

Each layer has a clear responsibility:

- Domain
- Application
- Infrastructure
- Presentation

---

## 8. Strong Typing

Avoid primitive obsession.

Important concepts should use dedicated types when appropriate.

---

## 9. Meaningful Naming

Names must be descriptive and professional.

Short names are avoided unless they are universally understood.

---

## 10. Maintainability First

Code quality and future evolution are priorities.

---

## 11. Documentation Driven Development

Important architectural decisions must be documented.

---

## 12. Security By Design

Security considerations must be included from the beginning.

---

## 13. Consistency

All project components must follow the same standards.
