# Back-end - API REST en .NET C#

Este proyecto es el back-end de la aplicación, desarrollado en **.NET 9** (ajusta la versión según tu proyecto) usando **C#**. Proporciona una API REST para la gestión de datos y se conecta a una base de datos **SQL Server** para almacenar y consultar la información.

---

## Tecnologías utilizadas

- .NET 9 (C#)
- ASP.NET Core Web API
- Entity Framework Core (ORM)
- SQL Server
- Swagger (para documentación y pruebas de la API)
- Dependencias gestionadas con NuGet

---

## Configuración de la base de datos

La conexión con la base de datos SQL Server se configura en el archivo `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=TU_SERVIDOR;Database=TU_BASE_DE_DATOS;User Id=TU_USUARIO;Password=TU_CONTRASEÑA;"
  }
}
