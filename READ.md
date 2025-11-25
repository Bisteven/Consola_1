# 📚 TIPOS Y MATRÍCULA – CONSOLA DIDÁCTICA 2025

## 🎓 Proyecto formativo – ADSO
## creadores del proyecto : Andres narvaez mejia , brahian estiven cataño

## Creadores del proyecto: Equipo ADSO (grupo de práctica Tipos de Datos)

---

# 📋 PORTADA

**Proyecto:** Tipos y Matrícula – Consola Interactiva  
**Versión:** 1.0.0  
**Año:** 2025  
**Tecnología:** .NET 8.0 – Console App  
**Desarrollado con:** C# 12  
**Licencia:** Uso académico  

---

# 📖 INTRODUCCIÓN

El **Sistema Tipos y Matrícula** es una aplicación de consola creada para reforzar conocimientos de los aprendices de ADSO sobre tipos de datos en C#. El menú interactivo permite practicar operaciones aritméticas, de cadenas, lógicas y de manipulación básica de objetos (clase `Persona`). Aunque es un proyecto ligero, condensa buenas prácticas: validación con `TryParse`, encapsulamiento en clases y manejo de menús en consola.

## Objetivos del Proyecto

- Guiar al aprendiz en operaciones con `int`, `double`, `float`, `string` y `bool`.
- Mostrar un ejemplo sencillo de creación y modificación de objetos (`Persona`).
- Practicar validaciones de entrada y manejo de errores comunes en consola.
- Servir como punto de partida para ejercicios más avanzados de persistencia y POO.

## Características Principales

✅ **Menú didáctico paso a paso**
- Navegación con opciones numeradas y retroalimentación inmediata.
- Limpieza automática de pantalla después de cada operación.

✅ **Operaciones por tipo de dato**
- Aritmética completa para `int`, `double` y `float`.
- Manipulación de cadenas: concatenación, comparación y casing.
- Evaluación lógica con operadores `&&`, `||`, `!`, `^`.

✅ **Ejemplo con objetos**
- Instanciación de una clase `Persona`.
- Métodos para mostrar información y validar si es mayor de edad.
- Opción para modificar la edad en tiempo real.

---

# 📑 ÍNDICE

1. [Requisitos del Sistema](#1-requisitos-del-sistema)  
2. [Instalación y Ejecución](#2-instalación-y-ejecución)  
3. [Estructura del Proyecto](#3-estructura-del-proyecto)  
4. [Arquitectura de la Aplicación](#4-arquitectura-de-la-aplicación)  
5. [Documentación del Código](#5-documentación-del-código)  
   - [5.1. Punto de entrada](#51-punto-de-entrada)  
   - [5.2. Menú y navegación](#52-menú-y-navegación)  
   - [5.3. Operaciones por tipo](#53-operaciones-por-tipo)  
   - [5.4. Clase `Persona`](#54-clase-persona)  
6. [Flujo de Funcionamiento](#6-flujo-de-funcionamiento)  
7. [Tecnologías Utilizadas](#7-tecnologías-utilizadas)  
8. [Casos de Prueba Manuales](#8-casos-de-prueba-manuales)  
9. [Notas y Mejoras Futuras](#9-notas-y-mejoras-futuras)  

---

# 1. REQUISITOS DEL SISTEMA

## Requisitos mínimos

- **.NET SDK:** Versión 8.0 o superior  
- **Sistema operativo:** Windows 10/11, Linux o macOS  
- **Editor de código:** Visual Studio 2022, Visual Studio Code, Rider o cualquier IDE compatible con C#  
- **Terminal:** CMD, PowerShell, Bash u otra consola que soporte `dotnet`  

## Dependencias

- No existen paquetes externos; todo el código se encuentra en `Program.cs`.

---

# 2. INSTALACIÓN Y EJECUCIÓN

1. **Clonar o descargar el proyecto**
   ```bash
   git clone <url-del-repositorio>
   cd Consola_1
   ```
2. **Restaurar dependencias (opcional en proyectos de consola simples)**
   ```bash
   dotnet restore
   ```
3. **Compilar el proyecto**
   ```bash
   dotnet build
   ```
4. **Ejecutar la aplicación**
   ```bash
   dotnet run
   ```
5. **Interacción**
   - La consola mostrará el menú principal.
   - Selecciona la opción deseada escribiendo el número y presionando Enter.

---

# 3. ESTRUCTURA DEL PROYECTO

```
Consola_1/
├── bin/                        # Archivos compilados
├── obj/                        # Archivos intermedios de compilación
├── Program.cs                  # Código fuente completo
├── TiposYMatricula.csproj      # Archivo de proyecto .NET
└── read.md                     # Documentación del proyecto
```

---

# 4. ARQUITECTURA DE LA APLICACIÓN

- **Tipo de aplicación:** consola (sin capas adicionales).
- **Namespace principal:** `TiposYMatricula`.
- **Clases:**
  - `Program`: contiene `Main`, el menú y las operaciones por tipo de dato.
  - `Persona`: clase modelo con propiedades autoimplementadas y métodos utilitarios.
- **Flujo:**
  1. `Main` inicia un ciclo `while` (`continuar`) que muestra el menú y procesa la opción ingresada.
  2. La opción se deriva mediante `switch (opcion)`.
  3. Cada caso ejecuta un método `OperacionesCon<Tipo>()`.
  4. Tras finalizar, se espera una tecla y se limpia la consola para volver al menú.

---

# 5. DOCUMENTACIÓN DEL CÓDIGO

Toda la lógica reside en `Program.cs`. A continuación se detalla cada bloque con su ubicación.

## 5.1. Punto de entrada

- **Archivo:** `Program.cs`
- **Método:** `static void Main(string[] args)`
- **Responsabilidad:** iniciar el bucle `while (continuar)` y coordinar la navegación.

```15:59:Program.cs
static void Main(string[] args)
{
    bool continuar = true;

    while (continuar)
    {
        MostrarMenu();
        string opcion = Console.ReadLine() ?? "";

        switch (opcion)
        {
            case "1":
                OperacionesConInt();
                break;
            // ...
            case "0":
                continuar = false;
                Console.WriteLine("¡Hasta luego!");
                break;
            default:
                Console.WriteLine("Opción no válida. Intente de nuevo.");
                break;
        }

        if (continuar)
        {
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
```

**Notas clave:**
- La lectura de la opción se protege con el operador `?? ""` para evitar `null`.
- `Console.Clear()` mantiene una experiencia limpia entre ejecuciones.

## 5.2. Menú y navegación

- **Archivo:** `Program.cs`
- **Método:** `static void MostrarMenu()`

```63:78:Program.cs
static void MostrarMenu()
{
    Console.WriteLine("╔════════════════════════════════════╗");
    Console.WriteLine("║      MENÚ - TIPOS DE DATOS         ║");
    // ...
    Console.Write("Seleccione una opción: ");
}
```

**Descripción:** imprime el menú con arte ASCII para hacerlo más visual.

## 5.3. Operaciones por tipo

### 5.3.1. Enteros

- **Ubicación:** `Program.cs` → `OperacionesConInt()`
- **Funciones clave:** `int.TryParse`, operaciones `+`, `-`, `*`, `/`, `%`.
- **Validación:** evita división por cero (`if (num2 != 0)`).

### 5.3.2. Cadenas

- **Ubicación:** `Program.cs` → `OperacionesConString()`
- **Acciones:** concatenación, cálculo de longitud, comparación con `Equals`, búsqueda con `Contains`, cambios de casing con `ToUpper`/`ToLower`.

### 5.3.3. Double

- **Ubicación:** `Program.cs` → `OperacionesConDouble()`
- **Extras:** `Math.Pow(num1, 2)` y `Math.Sqrt(num1)` como ejemplos de funciones matemáticas.

### 5.3.4. Float

- **Ubicación:** `Program.cs` → `OperacionesConFloat()`
- **Extras:** `Math.Abs(num1)` para ilustrar valor absoluto.

### 5.3.5. Boolean

- **Ubicación:** `Program.cs` → `OperacionesConBoolean()`
- **Operadores:** `&&`, `||`, `!`, `^`.
- **Validación:** `bool.TryParse` para asegurar entradas `true/false`.

### 5.3.6. Objeto `Persona`

- **Ubicación:** `Program.cs` → `OperacionesConObjeto()`
- **Pasos:**
  1. Captura `nombre` y `edad`.
  2. Instancia `Persona`.
  3. Muestra la información con `persona.MostrarInformacion()`.
  4. Consulta `persona.EsMayorDeEdad()`.
  5. Permite modificar `Edad` si el usuario responde “s”.

## 5.4. Clase `Persona`

- **Archivo:** `Program.cs` (parte inferior).
- **Estructura:**
  - Propiedades: `public string Nombre { get; set; }`, `public int Edad { get; set; }`.
  - Constructor: recibe `nombre` y `edad`.
  - `MostrarInformacion()`: retorna la cadena `Nombre: {Nombre}, Edad: {Edad} años`.
  - `EsMayorDeEdad()`: devuelve `Edad >= 18`.

---

# 6. FLUJO DE FUNCIONAMIENTO

1. **Inicio:** ejecutar `dotnet run`.  
2. **Menú:** seleccionar la opción según el tipo de dato.  
3. **Ingreso de datos:** la aplicación solicita los valores necesarios.  
4. **Procesamiento:** se muestran resultados detallados o mensajes de error.  
5. **Retorno al menú:** presionar cualquier tecla para repetir o elegir otra opción.  
6. **Salida:** ingresar `0` para finalizar y mostrar “¡Hasta luego!”.  

---

# 7. TECNOLOGÍAS UTILIZADAS

- **Lenguaje:** C# 12  
- **Framework:** .NET 8.0 (Console App)  
- **IDE sugeridos:** Visual Studio, VS Code o JetBrains Rider  
- **Bibliotecas estándar:** `System`, `System.Math` (para operaciones numéricas)  

---

# 8. CASOS DE PRUEBA MANUALES

| # | Escenario | Pasos | Resultado esperado |
| --- | --- | --- | --- |
| 1 | Operaciones con enteros | Opción `1` → ingresar `10` y `2` | Se muestran suma, resta, multiplicación, división `5` y módulo `0`. |
| 2 | División entre cero | Opción `1` → `5` y `0` | Mensaje “No se puede dividir por cero.” |
| 3 | Operaciones con cadenas vacías | Opción `2` → `""` y `hola` | Concatenación `"hola"`, longitudes 0 y 4. |
| 4 | Boolean incorrecto | Opción `5` → escribir `verdadero` | Mensaje de error de `bool.TryParse`. |
| 5 | Persona mayor de edad | Opción `6` → nombre Ana, edad 20 | `Es mayor de edad?: True`. |
| 6 | Actualizar edad | Opción `6` → aceptar cambio y poner 25 | Muestra la información con la nueva edad. |

---

# 9. NOTAS Y MEJORAS FUTURAS

- Internacionalizar el menú (es/en).  
- Persistir los datos ingresados en archivos JSON o una base de datos.  
- Añadir pruebas automatizadas con `dotnet test`.  
- Separar cada clase en archivos distintos (`Program`, `Persona`, utilidades).  
- Incluir manejo de excepciones más detallado para entradas no válidas.  

---

**© 2025 – Tipos y Matrícula | Proyecto formativo ADSO**  
*Desarrollado con .NET 8.0 Console App*

