# LPOO II 2026 - Laboratorio de Programación Orientada a Objetos II
**Carrera:** Analista Programador Universitario (APU) - Facultad de Ingeniería (UNJu)  
**Trabajo Práctico N° 1:** Creando Aplicaciones WPF (Mueblería)  
**Grupo:** 13  

---

## 🏛️ Arquitectura de la Solución

El proyecto sigue una arquitectura en capas con estricta **separación de responsabilidades**:

```
LPOO2/
├── docs/
│   ├── enunciados/           # Enunciados oficiales (LPOOII-TP1.pdf)
│   └── teoria/               # Apuntes teóricos de las Unidades 1 a 4 (WPF)
└── LPOOII_GRUPO13/
    ├── LPOOII_GRUPO13.sln    # Solución Visual Studio (VS 2010 / VS 2022)
    ├── ClasesBase/           # BIBLIOTECA DE CLASES (Capa de Dominio)
    │   ├── Proveedor.cs
    │   ├── Cliente.cs
    │   ├── Producto.cs
    │   ├── Vendedor.cs
    │   ├── Venta.cs
    │   └── ClassDiagram1.cd  # Diagrama de Clases
    └── Vistas/               # APLICACIÓN WPF (Capa de Presentación)
        ├── App.xaml / App.xaml.cs
        ├── Login.xaml         # Ventana de Login con roles hardcoded
        ├── MenuPrincipal.xaml # Dashboard con fondo e impacto de permisos
        ├── FormProveedor.xaml # ABM con máquina de estados y MessageBox
        ├── FormCliente.xaml
        ├── FormProducto.xaml
        ├── FormVendedor.xaml  # Exclusivo para rol Admin
        └── Images/
            └── fondo.jpg      # Imagen de fondo del formulario principal
```

---

## 🔑 Credenciales de Acceso (Hardcoded)

Para verificar los requerimientos del práctico:

| Rol | Usuario | Contraseña | Permisos |
|---|---|---|---|
| **Administrador** | `admin` | `admin` | Acceso completo (incluyendo ABM Vendedores) |
| **Vendedor** | `vendedor` | `vendedor` | Acceso a Proveedores, Clientes y Productos (Vendedores restringido) |

---

## ⚙️ Stack y Verificación en tu PC

Tu entorno cuenta con todas las herramientas necesarias:
* **Visual Studio 2010:** Instalado en tu máquina (`C:\Program Files (x86)\Microsoft Visual Studio 10.0\Common7\IDE\devenv.exe`). Podés hacer doble clic sobre `LPOOII_GRUPO13\LPOOII_GRUPO13.sln` para abrir el entorno de la cátedra.
* **.NET Framework 4.0:** Paquete de compilación nativo instalado y verificado.
* **MSBuild / Compilación por Terminal:** Compilado con 0 errores y 0 advertencias.
* **Git:** Repositorio inicializado en la rama `main` con `.gitignore` para no subir archivos temporales (`bin/`, `obj/`, `.vs/`).

---

## 👥 Flujo de Colaboración con tus Compañeros

1. **Clonar el Repositorio (Compañeros):**
   ```bash
   git clone https://github.com/mmarcoschambi/apu-lpoo2-26.git
   ```
2. **Buenas prácticas para el equipo:**
   * Cada integrante trabaja en una rama feature (ej: `git checkout -b feature/tp1-vistas`).
   * Nunca commitear binarios ni carpetas de compilación (`.gitignore` ya configurado).
   * Para la entrega final: generar el archivo comprimido `.rar` del directorio `LPOOII_GRUPO13` tras limpiar la solución.
