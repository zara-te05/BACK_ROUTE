# 🚀 Backend Journey: ASP.NET Core & Python Roadmap

Este repositorio es mi bitácora de aprendizaje y laboratorio de experimentación para dominar el desarrollo **Backend**. Mi objetivo es consolidar un perfil sólido en arquitectura de software, gestión de datos y escalabilidad antes de mis prácticas profesionales.

---

## 🛠️ Stack Tecnológico Principal
* **Lenguajes:** C# (.NET 8+), Python 3.x
* **Bases de Datos:** SQL Server, PostgreSQL, SQLite
* **Herramientas:** Entity Framework Core (EF), Dapper, Docker, xUnit, AutoMapper

---

## 🗺️ Roadmap de Proyectos

### 📂 [Nivel 1] Fundamentos y Persistencia (SQL & EF Core)
**Proyecto:** *Inventory Engine*
* **Enfoque:** Dominar el flujo de datos y reglas de negocio en la DB.
* **Checklist:**
    * [ ] Configuración de Fluent API y Migraciones.
    * [ ] Relaciones complejas (1:N, N:N) y Navegación.
    * [ ] Implementación de **Soft Delete** mediante Global Query Filters.
    * [ ] Consultas LINQ optimizadas y Paginación.

### 📂 [Nivel 2] Arquitectura de APIs (REST Estándar)
**Proyecto:** *EduAPI - Plataforma de Cursos*
* **Enfoque:** Construir servicios desacoplados, seguros y documentados.
* **Checklist:**
    * [ ] Implementación de **DTOs** y AutoMapper.
    * [ ] Validaciones de entrada con **FluentValidation**.
    * [ ] Middleware global para manejo de excepciones.
    * [ ] Documentación completa con **Swagger/OpenAPI**.

### 📂 [Nivel 3] Seguridad y Autenticación
**Proyecto:** *AuthGuard Service*
* **Enfoque:** Identidad, protección de recursos y comunicación.
* **Checklist:**
    * [ ] Implementación de **ASP.NET Core Identity**.
    * [ ] Autenticación basada en **JWT (JSON Web Tokens)**.
    * [ ] Manejo de Roles y Claims (RBAC).
    * [ ] Integración de servicios externos (SMTP/Email/SMS).

### 📂 [Nivel 4] Performance y Escalamiento
**Proyecto:** *RealEstate Finder*
* **Enfoque:** Optimización extrema para grandes volúmenes de datos.
* **Checklist:**
    * [ ] Consultas de alta velocidad con **Dapper** (Micro-ORM).
    * [ ] Implementación de Caching (Redis o IMemoryCache).
    * [ ] Estrategias de Indexación avanzada en SQL Server.
    * [ ] Configuración de CORS y Rate Limiting.

### 📂 [Nivel 5] Cloud, Docker y DevOps
**Proyecto:** *ReportProcessor Microservice*
* **Enfoque:** Despliegue moderno, testing y tareas asíncronas.
* **Checklist:**
    * [ ] Dockerización de la App y DB (Docker Compose).
    * [ ] Tareas en segundo plano con **Hangfire** o BackgroundWorkers.
    * [ ] Unit Testing con **xUnit** y **Moq**.
    * [ ] Implementación de Logging estructurado con **Serilog**.

---

## 🐍 Sección Python (Automatización y ML)
Módulos enfocados en la versatilidad de Python como soporte backend:
* **Automation:** Scripts para backups de DB y manipulación de archivos.
* **Data Science:** Análisis de tendencias con **Pandas**.
* **FastAPI:** Exposición de modelos de Machine Learning como microservicios.

---

## 📝 Notas de Comandos Rápidos
* `dotnet ef migrations add Name`: Crear migración.
* `dotnet ef database update`: Aplicar cambios a la DB.
* `docker-compose up --build`: Levantar todo el entorno local.

---
*“El código limpio siempre parece que fue escrito por alguien a quien le importa.”* 💻# BACK_ROUTE
