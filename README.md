# 📦 Tinccita

## 📁 Estructura del Proyecto

Este repositorio sigue una arquitectura CLEAN con dos WebAPIs separadas para manejar contenido estático (SSG) y formularios dinámicos.

```
📦 Tinccita
│
├── 📂 backend (Arquitectura CLEAN con dos WebAPIs)
│   ├── Tinccita.sln        # Solución .NET Core
│   │
│   ├── 📂 Tinccita-SSG        # API para contenido estático (SSG)
│   ├── 📂 Tinccita-Dynamic    # API para formularios dinámicos
│   ├── 📂 Tinccita.Domain     # Dominio (Modelos, Interfaces)
│   │   ├── 📂 SSG             # Modelos y lógica para SSG
│   │   ├── 📂 Dynamic         # Modelos y lógica para la API dinámica
│   │   ├── BaseEntity.cs      # Código compartido
│   ├── 📂 Tinccita.Application # Casos de uso y lógica de la aplicación
│   │   ├── 📂 SSG             # Casos de uso para SSG
│   │   ├── 📂 Dynamic         # Casos de uso para API dinámica
│   │   ├── 📂 Commons         # Código compartido entre APIs
│   ├── 📂 Tinccita.Infraestructure # Repositorios y acceso a datos
│   │   ├── 📂 SSG             # Repositorios y persistencia para SSG
│   │   ├── 📂 Dynamic         # Repositorios y persistencia para API dinámica
│   │   ├── DatabaseContext.cs # Código compartido
│   ├── 📂 Tinccita.Shared      # Código compartido (helpers, constantes, etc.)
│   │   ├── Helpers.cs         # Métodos utilitarios
│   │   ├── Constants.cs       # Constantes globales
│
├── 📂 frontend-ssg        # Frontend - Contenido Estático (SSG con Nuxt)
│   ├── package.json
│   ├── nuxt.config.ts
│   ├── pages/
│   ├── components/
│   ├── static/
│   ├── store/
│   ├── dist/              # Generado con `npm run generate`
├── 📂 frontend-dynamic    # Frontend - Interacción Dinámica (Vue.js con Vite)
│   ├── package.json
│   ├── vite.config.ts
│   ├── src/
│   │   ├── components/
│   │   ├── views/
│   │   ├── router/
│   │   ├── store/
│   │   └── main.ts
├── 📂 deploy             # Scripts para Despliegue en IIS
│   ├── webdeploy-backend-ssg.ps1      # Despliega Tinccita-SSG en IIS
│   ├── webdeploy-backend-dynamic.ps1  # Despliega Tinccita-Dynamic en IIS
│   ├── webdeploy-frontend-ssg.ps1     # Copia `dist/` a IIS
│   └── webdeploy-frontend-dynamic.ps1 # Despliega Vue.js dinámico en IIS
│
├── 📂 .github             # Carpeta para GitHub Actions y otros workflows
│   ├── workflows/
│   │   ├── build.yml      # Ejemplo de workflow para CI/CD
│
├── .gitignore             # Archivos y directorios que Git debe ignorar
├── .gitattributes         # Configuración específica de atributos de archivos en Git
└── README.md              # Documentación del proyecto
