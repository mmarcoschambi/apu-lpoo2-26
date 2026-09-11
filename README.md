# LPOO II 2026 - Laboratorio de Programación Orientada a Objetos II
**Carrera:** Analista Programador Universitario (APU) - Facultad de Ingeniería (UNJu)  
**Trabajo Práctico N° 1:** Creando Aplicaciones WPF  
**Grupo:** 13  
**Estado:** Fase 0 (Scaffolding inicial / Proyectos listos para implementación)

---

## 🏛️ Estructura del Repositorio (Fase 0)

```
LPOO2/
├── docs/
│   ├── enunciados/           # Enunciados oficiales (LPOOII-TP1.pdf)
│   └── teoria/               # Apuntes teóricos de las Unidades 1 a 4 (WPF)
└── LPOOII_GRUPO13/
    ├── LPOOII_GRUPO13.sln    # Solución Visual Studio (VS 2010 / VS 2022)
    ├── ClasesBase/           # BIBLIOTECA DE CLASES (.NET Framework 4.0)
    │   ├── ClasesBase.csproj # Proyecto listo para ítems 1 y 2
    │   └── Class1.cs
    └── Vistas/               # APLICACIÓN WPF (.NET Framework 4.0)
        ├── Vistas.csproj     # Proyecto WPF referenciando ClasesBase
        ├── App.xaml / App.xaml.cs
        └── MainWindow.xaml / MainWindow.xaml.cs
```

---

## ⚙️ Stack y Verificación en tu PC

* **Visual Studio 2010:** Instalado nativamente. Podés abrir `LPOOII_GRUPO13\LPOOII_GRUPO13.sln`.
* **.NET Framework 4.0:** Verificado. Compila de punta a punta con 0 errores.
* **Git:** Repositorio en rama `main` con `.gitignore` para ignorar `bin/`, `obj/` y `.vs/`.

---

## 👥 Flujo de Colaboración con tus Compañeros

1. **Clonar el Repositorio (Compañeros):**
   ```bash
   git clone https://github.com/mmarcoschambi/apu-lpoo2-26.git
   ```
2. **Convención de Trabajo:**
   * Cada integrante o feature en su propia rama (ej: `git checkout -b feature/item-1-clasesbase`).
   * No commitear binarios ni temporales (ya gestionado por `.gitignore`).
