# 📦 Tinccita

## 💡 Tecnologías

Este repositorio sigue una arquitectura CLEAN con una estructura híbrida en el backend (MVC + WebAPI) y el uso de Vue.js en el frontend.

- Backend:
  - TargetFramework: 8.0.
  - Arquitectura CLEAN: Se divide en bibliotecas de clases que sirven tanto para un MVC como un WebAPI:
    - MVC:
      - Proyecto ASP.NET Core Web App (Model-View-Controller).
      - Sirve vistas RAZOR que incluyen componentes de Vue.js compilados desde el frontend.
      - Utiliza Bootstrap 5 para el diseño de las vistas y Vue.js para agregar interactividad a los elementos dinámicos en las vistas.
    - WebAPI:
      - Proyecto ASP.NET Core Web API.
      - Maneja cambios de estado y proporciona endpoints para ser consumidos por el frontend.
      - Utiliza Axios o fetch para interactuar con los datos a través de las APIs.
- Frontend:
  - Hecho con Vue.js 3 para manejar la interactividad.
  - Vite como herramienta de compilación y empaquetado.
  - Integración con MVC:
    - Los archivos generados por Vite/Webpack (principalmente .js y .css) se copian en el directorio wwwroot/js/ dentro del proyecto MVC.
    - Las vistas RAZOR (.cshtml) cargan estos archivos y permiten manejar la interactividad en formularios y otros elementos dinámicos de la página.
    - Para flujos altamente interactivos sin recargar la página, se comunica con el WebAPI del backend mediante llamadas fetch o Axios.
- Presentación (MVC y Vue.js 3): 
  - Librerías:
    - Bootstrap 5: Para el diseño de las vistas y componentes básicos.
    - BootstrapVueNext: Componentes prediseñados con BootstrapVueNext para Vue.js 3, utilizados para facilitar la construcción de componentes reactivos como formularios.
  - CSS y SCSS:
    - El archivo SCSS se usa para sobreescribir y personalizar las variables de Bootstrap 5 y otros estilos globales.

4️⃣ Ejemplo de flujo:

1. Backend (MVC) genera la vista que contiene elementos estáticos (HTML, Razor).
2. Vue.js es incluido en el archivo de la vista mediante un archivo compilado con tecnología Vite/Webpack y servido desde el wwwroot del backend.
3. Vue.js se encarga de manejar la interactividad en los elementos dentro de la vista; para así tener formularios dinámicos, validaciones y llamadas al Backend (Dynamic).

🔄 Flujo de Despliegue:

- Frontend:
  - Ejecuta npm run build o vite build para compilar el frontend.
  - Los archivos resultantes se copian en la carpeta wwwroot/js/ de la aplicación MVC.
- Backend:
  - Se configura y despliega en IIS utilizando Web Deploy.

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
│   │       │── 📂 RestClients         # Clientes para APIs REST
│   │       │   │── IExternalApiService.cs  # Interfaz del servicio REST
│   │       │   │── ExternalApiService.cs   # Implementación del servicio REST
│   │       │
│   │       │── 📂 SoapClients         # Clientes para WebServices SOAP
│   │          │── IExternalSoapService.cs  # Interfaz del servicio SOAP
│   │          │── ExternalSoapService.cs   # Implementación del servicio SOAP
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
│
├── 📂 .github             # Carpeta para GitHub Actions y otros workflows
│   ├── workflows/
│   │   ├── build.yml      # Ejemplo de workflow para CI/CD
│
├── .gitignore             # Archivos y directorios que Git debe ignorar
├── .gitattributes         # Configuración específica de atributos de archivos en Git
└── README.md              # Documentación del proyecto