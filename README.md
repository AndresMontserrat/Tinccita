# 📦 Tinccita

## 💡 Tecnologías

Este repositorio sigue una arquitectura CLEAN con una estructura híbrida en el backend (MVC + WebAPI) y el uso de Vue.js en el frontend.

- Backend:
  - TargetFramework: 8.0.
  - Arquitectura CLEAN, con bibliotecas de clases que sirven tanto a un MVC como a un WebAPI:
    - MVC: Proyecto ASP.NET Core Web App (Model-View-Controller) que sirve vistas RAZOR, en las cuales se integran componentes de Vue.js compilados desde el frontend.
    - WebAPI: Proyecto ASP.NET Core Web API, diseñado para manejar cambios de estado y proporcionar endpoints consumidos por el frontend. 

- Frontend:
    - Implementado con Vue.js 3, utilizando Vite como herramienta de compilación y empaquetado.
    - Integración con MVC:
       - Vue.js se compila con Vite/Webpack y los archivos resultantes (.js, .css) se copian en wwwroot/js/ dentro del proyecto MVC.
       - Las vistas RAZOR (.cshtml) cargan estos scripts para manejar la interactividad en los formularios y otros elementos dinámicos.
      - Para flujos que requieren alta interactividad sin recargar la página, se comunica con el WebAPI del backend mediante llamadas fetch o Axios.

- Deploy: 
    - Backend (MVC + WebAPI): Se despliega en IIS utilizando Web Deploy.
    - Frontend:
      - Se compila con Vite/Webpack (npm run build).
      - Los archivos resultantes (.js, .css) se copian en wwwroot/js/ dentro del proyecto MVC antes del despliegue.

4️⃣ Ejemplo de flujo:

1. Backend (MVC) genera la vista que contiene elementos estáticos (HTML, Razor).
2. Vue.js es incluido en el archivo de la vista mediante un archivo compilado con tecnología Vite/Webpack y servido desde el wwwroot del backend.
3. Vue.js se encarga de manejar la interactividad en los elementos dentro de la vista; para así tener formularios dinámicos, validaciones y llamadas al Backend (Dynamic).

🚀 Ventajas:
- Carga inicial rápida gracias a HTML estático renderizado por MVC.
- Interactividad dinámica sin necesidad de recargar la página.
- Optimizado para producción con Vue.js compilado con Vite en wwwroot/js/.
- Separación limpia de responsabilidades (MVC para vistas, Vue.js para interactividad).

## 📁 Estructura del Proyecto

```
📦 Tinccita
│
├── 📂 backend (Arquitectura CLEAN con dos WebAPIs)
│   ├── Tinccita.sln        # Solución .NET Core
│   │
│   ├── 📂 Tinccita-MVC        # Proyecto ASP.NET Core MVC para servir contenido estático
│   │
│   ├── 📂 Tinccita-Dynamic    # WebAPI para formularios dinámicos
│   │
│   ├── 📂 Tinccita.Domain     # Dominio (Modelos, Interfaces)
│   │   ├── 📂 MVC             # Modelos y lógica para MVC
│   │   ├── 📂 Dynamic         # Modelos y lógica para la API dinámica
│   │   ├── BaseEntity.cs      # Código compartido
│   │
│   ├── 📂 Tinccita.Application # Casos de uso y lógica de la aplicación
│   │   ├── 📂 MVC             # Casos de uso para MVC
│   │   ├── 📂 Dynamic         # Casos de uso para API dinámica
│   │   ├── 📂 Commons         # Código compartido entre APIs
│   │
│   │──📂 Tinccita.Infrastructure      # Capa de infraestructura (repositorios, acceso a datos y servicios externos)
│   │   │── 📂 MVC                     # Repositorios y persistencia para MVC
│   │   │   │── 📂 Migrations           # Migraciones de Entity Framework Core
│   │   │   │── 📂 Data                 # AppDbContext.cs (contexto de base de datos)
│   │   │   │── 📂 DependencyInjection  # ServiceContainer.cs (registros de servicios para MVC)
│   │   │   │── 📂 Repositories         # Operaciones CRUD para MVC
│   │   │
│   │   │── 📂 Dynamic                 # Repositorios y persistencia para API dinámica
│   │   │   │── 📂 Migrations           # Migraciones de Entity Framework Core
│   │   │   │── 📂 Data                 # AppDbContext.cs (contexto de base de datos)
│   │   │   │── 📂 DependencyInjection  # ServiceContainer.cs (registros de servicios para API dinámica)
│   │   │   │── 📂 Repositories         # Operaciones CRUD para API dinámica
│   │   │
│   │   │── 📂 ExternalServices        # Integración con APIs externas y WebServices SOAP
│   │   │   │── 📂 RestClients         # Clientes para APIs REST
│   │   │   │   │── IExternalApiService.cs  # Interfaz del servicio REST
│   │   │   │   │── ExternalApiService.cs   # Implementación del servicio REST
│   │   │   │
│   │   │   │── 📂 SoapClients         # Clientes para WebServices SOAP
│   │   │       │── IExternalSoapService.cs  # Interfaz del servicio SOAP
│   │   │       │── ExternalSoapService.cs   # Implementación del servicio SOAP
│   │   │
│   │   │── 📂 Shared                  # Clases comunes reutilizables
│   │       │── Helpers.cs             # Métodos auxiliares y utilidades
│   │       │── Constants.cs           # Definición de constantes globales
│   │
│   ├── 📂 Tinccita.Shared     # Código compartido (helpers, constantes, etc.)
│       ├── Helpers.cs         # Métodos utilitarios
│       ├── Constants.cs       # Constantes globales
│
├── 📂 frontend (Vue.js con Vite)
│   ├── package.json
│   ├── vite.config.ts
│   ├── src/
│   │   ├── components/        # Componentes Vue.js (formularios, modales, etc.)
│   │   ├── views/             # Vistas Vue.js (si aplicable)
│   │   ├── router/            # Rutas Vue Router (si necesario)
│   │   └── main.ts            # Punto de entrada de Vue.js
│   ├── dist/                  # Archivos compilados (build) de Vue.js
|
├── 📂 deploy             # Scripts para Despliegue en IIS
│   ├── webdeploy-backend-dynamic.ps1  # Despliega Tinccita-Dynamic en IIS
│   ├── webdeploy-backend-mvc.ps1      # Despliega Tinccita-MVC en IIS
│   └── webdeploy-frontend-dynamic.ps1 # Despliega Vue.js dinámico en IIS
│
├── 📂 .github             # Carpeta para GitHub Actions y otros workflows
│   ├── workflows/
│   │   ├── build.yml      # Ejemplo de workflow para CI/CD
│
├── .gitignore             # Archivos y directorios que Git debe ignorar
├── .gitattributes         # Configuración específica de atributos de archivos en Git
└── README.md              # Documentación del proyecto
