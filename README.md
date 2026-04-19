<div align="center">
  <img src="assets/images/whisky-readme-header.png?reload=true&v=1" alt="Whisky DDD Microservice Blueprint" width="100%">
</div>

# 🥃 WhiskyMicroserviceTemplate

A high-fidelity architectural blueprint for Domain-Driven Design (DDD) using C# .NET 9. Engineered as a crystal-clear starting point for AI-assisted orchestration (Claude Code) and professional domain modeling. Pre-integrated with **PostgreSQL (Aiven Cloud)** to simulate real-world Persistence-Ignorance and EF-Core workflows.

<br />

---

<br />


## 🏛️ Project Anatomy

The solution is organized alphabetically, following the physical file structure for instant orientation and seamless AI-agent navigation.

* **`Whisky.Tasting.API`**: The Entry Point. A clean ASP.NET Core API surface, exposing Minimal APIs, Controllers, and Swagger documentation.
* **`Whisky.Tasting.Application`**: The Orchestrator. Handles Commands, Queries, DTOs, and Validators. This is where the Use Cases and Application Services live.
* **`Whisky.Tasting.Domain`**: The Pure Heart. Contains Entities, Value Objects, Aggregates, and Domain Events. Zero dependencies on external frameworks.
* **`Whisky.Tasting.Infrastructure`**: The Technical Implementation. Defines EF-Core DBContext, Repository implementations, and manages the connection to the **Aiven PostgreSQL** cloud instance.

<br />

---

<br />

## ⚡ Tactical DDD & Feature Flow

This diagram visualizes how Tactical DDD objects are orchestrated across the layers and how the persistence logic interacts with the Cloud-DB.

<div align="center">
  <img src="assets/images/whisky-readme-ddd-features.png?reload=true&v=1" alt="Tactical DDD & Feature Flow Diagram" width="85%">
  <br />
  <br />

| Pattern | Responsibility | Layer |
| :--- | :--- | :--- |
| **Aggregate Root** | Ensures consistency for a group of related entities. | Domain |
| **Value Object** | Immutable object defined by its properties. | Domain |
| **Domain Event** | Captures significant business actions within the domain. | Domain |
| **Repository** | Interface for Domain, Implementation in Infrastructure. | Domain/Infra |

</div>

<br />

---

<br />

## 🛠️ Infrastructure & Data Validation

The template provides an immediate, live data context to validate your domain logic and persistence mappings without setting up a local database.

* **Aiven Cloud PostgreSQL:** Pre-integrated connection with a default **Whisky Database** schema.
* **Instant EF-Core Mapping Validation:** Immediately test your Domain-to-Database entity mappings.
* **Persistence-Ignorance:** The Domain logic interacts only with interfaces, ensuring a clean separation from infrastructure.

<br />

---

<br />

## 🤖 AI-Ready Boilerplate

This repository is optimized for use with AI-coding agents like **Claude Code**. The standardized, modular structure allows the AI to:
1.  **Understand the Domain Model** instantly by analyzing the `Whisky.Tasting.Domain` layer.
2.  **Generate New Services** that perfectly align with your established architecture and EF-Core schema.
3.  **Scale with Consistency**, maintaining the Clean Architecture boundaries throughout the development lifecycle.

<br />

---

<br />

&nbsp;&nbsp;&nbsp;<a href="https://github.com/Froschkoenig84"><img src="assets/images/mnicolai-readme-sealbatch.png?reload=true" align="right" width="120" alt="Michael Nicolai Seal"></a><br>

> *This is a streamlined architectural blueprint focusing on the pure essence of DDD. It serves as a high-fidelity reference for AI-driven service generation and professional domain modeling.*

<div align="right">
  <a href="https://github.com/Froschkoenig84">by Froschkoenig84</a>
</div><br clear="right">
