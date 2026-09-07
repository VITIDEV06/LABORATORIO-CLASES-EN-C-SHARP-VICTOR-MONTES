# Laboratorio #2: Clases en C#

<div align="center">

<img src="https://img.shields.io/badge/C%23-Programming-239120?style=for-the-badge&logo=csharp&logoColor=white" alt="C#">
<img src="https://img.shields.io/badge/.NET-Framework-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET">
<img src="https://img.shields.io/badge/Visual%20Studio-IDE-5C2D91?style=for-the-badge&logo=visualstudio&logoColor=white" alt="Visual Studio">
<img src="https://img.shields.io/badge/GitHub-Repository-181717?style=for-the-badge&logo=github&logoColor=white" alt="GitHub">

<br><br>

### Orientación a Objetos

**Implementación de clases y objetos utilizando C#**

<br>

![Status](https://img.shields.io/badge/Estado-Completado-success?style=flat-square)
![Language](https://img.shields.io/badge/Lenguaje-C%23-blue?style=flat-square)
![Paradigm](https://img.shields.io/badge/Paradigma-POO-orange?style=flat-square)

</div>

---

## Descripción

Este repositorio contiene la solución de los **tres problemas correspondientes al Laboratorio #2: Clases en C#**, desarrollado como parte de la asignatura de **Orientación a Objetos**.

El laboratorio tiene como propósito poner en práctica los fundamentos iniciales de la **Programación Orientada a Objetos (POO)** mediante la creación y utilización de clases en C#, trabajando progresivamente con objetos, métodos, constructores, atributos y propiedades.

Los ejercicios presentan una evolución desde un programa básico hasta la implementación de una clase con encapsulamiento y propiedades.

---

## Objetivos

* Comprender la estructura básica de una clase en C#.
* Crear e instanciar objetos a partir de una clase.
* Implementar métodos dentro de una clase.
* Utilizar parámetros en métodos.
* Implementar constructores.
* Aplicar el concepto de encapsulamiento mediante atributos privados.
* Utilizar propiedades `get` y `set`.
* Manipular los datos de diferentes objetos.
* Comprender la interacción entre el programa principal y las clases definidas.

---

## Tecnologías utilizadas

<div align="center">

| Tecnología        | Uso                                  |
| ----------------- | ------------------------------------ |
| **C#**            | Lenguaje de programación utilizado   |
| **.NET**          | Plataforma de desarrollo y ejecución |
| **Visual Studio** | Entorno de desarrollo                |
| **GitHub**        | Repositorio y control del código     |

</div>

---

# Ejercicios

## Problema 1 — Introducción al Libro de Calificaciones

### Descripción

El primer ejercicio presenta una implementación básica relacionada con un **libro de calificaciones**.

El programa muestra un mensaje de bienvenida utilizando la consola de C#, sirviendo como introducción a la estructura de un programa y al uso de `Console.WriteLine()`.

### Conceptos aplicados

* Estructura básica de un programa en C#.
* Método `Main()`.
* Uso de `Console.WriteLine()`.
* Espacios de nombres mediante `namespace`.
* Ejecución de una aplicación de consola.

### Ejemplo de salida

```text
Hola Bienvenido al Libro de calificaciones.
```

---

# Problema 2 — Creación de una Clase

### Descripción

En el segundo ejercicio se introduce formalmente el concepto de **clase y objeto**.

Se crea una clase denominada `MiLibroCalificasiones`, la cual contiene el método `MostrarMensaje()`.

Desde el programa principal se instancia un objeto de esta clase y se solicita al usuario el nombre del curso para posteriormente enviarlo como parámetro al método.

### Estructura principal

```text
Programa principal
       │
       ▼
Crear objeto MiLibroCalificasiones
       │
       ▼
Solicitar nombre del curso
       │
       ▼
MostrarMensaje(nombreCurso)
       │
       ▼
Mostrar información en consola
```

### Conceptos de POO aplicados

* Definición de clases.
* Creación de objetos.
* Instanciación mediante `new`.
* Métodos.
* Parámetros.
* Comunicación entre el programa principal y una clase.
* Entrada de datos mediante `Console.ReadLine()`.

### Ejemplo

```csharp
MiLibroCalificasiones MyLibro = new MiLibroCalificasiones();

string nombreCurso = Console.ReadLine();

MyLibro.MostrarMensaje(nombreCurso);
```

La clase recibe el nombre del curso mediante el parámetro del método:

```csharp
public void MostrarMensaje(string nombreCurso)
{
    Console.WriteLine(
        "!Bienvenido al libro de calificaciones para: \n{0}",
        nombreCurso
    );
}
```

---

# Problema 3 — Constructores, Propiedades y Encapsulamiento

### Descripción

El tercer ejercicio amplía los conceptos utilizados anteriormente e incorpora elementos fundamentales de la Programación Orientada a Objetos.

Se desarrolla la clase `LibroCalificaciones`, que posee un atributo privado para almacenar el nombre del curso.

Además, se implementa un **constructor** para inicializar el objeto y una **propiedad `NombreCurso`** que permite acceder y modificar el valor del atributo privado.

El programa principal crea dos objetos independientes de la clase:

```csharp
LibroCalificaciones MyLibro =
    new LibroCalificaciones("CS101 Programacion en C#");

LibroCalificaciones MyLibro2 =
    new LibroCalificaciones("CS102 Estructura de datos");
```

Posteriormente, se solicita al usuario un nuevo nombre de curso y se actualiza el valor mediante la propiedad.

### Conceptos de POO aplicados

* Clases.
* Objetos.
* Constructores.
* Atributos privados.
* Encapsulamiento.
* Propiedades.
* `get` y `set`.
* Creación de múltiples objetos.
* Modificación de atributos mediante propiedades.

### Constructor

El constructor permite inicializar el nombre del curso cuando se crea un objeto:

```csharp
public LibroCalificaciones(string nombre)
{
    nombreCurso = nombre;
}
```

### Encapsulamiento

El atributo se declara como privado:

```csharp
private string nombreCurso;
```

El acceso al atributo se controla mediante la propiedad:

```csharp
public string NombreCurso
{
    get { return nombreCurso; }
    set { nombreCurso = value; }
}
```

Esto permite aplicar el principio de **encapsulamiento**, evitando que el atributo sea manipulado directamente desde otras partes del programa.

---

# Evolución de los ejercicios

Los tres problemas presentan una progresión en la aplicación de los conceptos de Orientación a Objetos:

```text
┌───────────────────────────────────────┐
│ Problema 1                            │
│ Programa básico en C#                 │
│                                       │
│ Console.WriteLine()                   │
└──────────────────┬────────────────────┘
                   │
                   ▼
┌───────────────────────────────────────┐
│ Problema 2                            │
│ Introducción a clases y objetos       │
│                                       │
│ Clase + Objeto + Método + Parámetro   │
└──────────────────┬────────────────────┘
                   │
                   ▼
┌───────────────────────────────────────┐
│ Problema 3                            │
│ Aplicación de conceptos de POO        │
│                                       │
│ Constructor + Encapsulamiento         │
│ Atributos + Propiedades + Objetos     │
└───────────────────────────────────────┘
```

Esta progresión permite pasar de una aplicación básica de consola a una estructura que incorpora principios fundamentales de la Programación Orientada a Objetos.

---

# Estructura del proyecto

El laboratorio se encuentra organizado de manera que cada ejercicio contiene su respectivo programa principal y, cuando corresponde, las clases utilizadas.

```text
Laboratorio-2-Clases-CSharp/
│
├── Problema-1/
│   └── Program.cs
│
├── Problema-2/
│   ├── Program.cs
│   └── Class1.cs
│
├── Problema-3/
│   ├── Program.cs
│   └── Class1.cs
│
└── README.md
```

> **Nota:** Los nombres de las carpetas y archivos pueden variar dependiendo de la organización utilizada en el proyecto de Visual Studio.

---

# Conceptos fundamentales

## Clase

Una clase funciona como una estructura que define los datos y comportamientos que tendrán los objetos creados a partir de ella.

En este laboratorio se utilizan clases como:

```csharp
public class MiLibroCalificasiones
```

y:

```csharp
public class LibroCalificaciones
```

---

## Objeto

Un objeto es una instancia de una clase.

Por ejemplo:

```csharp
LibroCalificaciones MyLibro =
    new LibroCalificaciones("CS101 Programacion en C#");
```

Aquí `MyLibro` representa un objeto creado a partir de la clase `LibroCalificaciones`.

---

## Método

Los métodos representan comportamientos que puede realizar una clase.

Ejemplo:

```csharp
public void MostrarMensaje()
{
    Console.WriteLine(
        "Bienvenido al libro de calificaciones para: \n{0}",
        NombreCurso
    );
}
```

---

## Constructor

Un constructor permite inicializar un objeto al momento de su creación.

```csharp
public LibroCalificaciones(string nombre)
{
    nombreCurso = nombre;
}
```

---

## Encapsulamiento

El encapsulamiento permite controlar el acceso a los datos internos de una clase.

En el laboratorio se utiliza un atributo privado:

```csharp
private string nombreCurso;
```

y una propiedad pública:

```csharp
public string NombreCurso
{
    get { return nombreCurso; }
    set { nombreCurso = value; }
}
```

De esta manera, el acceso al dato se realiza mediante una interfaz controlada.

---

# Ejecución

Para ejecutar cualquiera de los ejercicios se requiere tener instalado **.NET** y un entorno compatible con C#.

### 1. Clonar el repositorio

```bash
git clone URL_DEL_REPOSITORIO
```

### 2. Acceder al proyecto

```bash
cd Laboratorio-2-Clases-CSharp
```

### 3. Ejecutar el ejercicio correspondiente

Desde Visual Studio:

1. Abrir el proyecto.
2. Seleccionar el ejercicio que se desea ejecutar.
3. Ejecutar mediante **Start / F5**.

También puede ejecutarse desde la terminal utilizando:

```bash
dotnet run
```

si el proyecto se encuentra configurado como una aplicación .NET.

---

# Aprendizajes obtenidos

A través de este laboratorio se reforzaron los fundamentos necesarios para comenzar a desarrollar aplicaciones utilizando el paradigma de **Programación Orientada a Objetos**.

Los ejercicios permiten comprender de manera progresiva:

* Cómo definir una clase.
* Cómo crear objetos.
* Cómo utilizar métodos.
* Cómo enviar información mediante parámetros.
* Cómo inicializar objetos mediante constructores.
* Cómo proteger atributos utilizando `private`.
* Cómo acceder y modificar información mediante propiedades.
* Cómo trabajar con múltiples objetos de una misma clase.

Estos conceptos constituyen una base fundamental para el desarrollo de aplicaciones más complejas utilizando C# y el paradigma orientado a objetos.

---

# Conclusión

El **Laboratorio #2: Clases en C#** permitió aplicar de manera práctica los conceptos iniciales de la Orientación a Objetos.

Los tres problemas muestran una evolución desde una aplicación sencilla de consola hasta la implementación de una clase con **atributos privados, constructores y propiedades**, demostrando cómo C# proporciona las herramientas necesarias para estructurar programas mediante objetos.

La realización de estos ejercicios establece una base para continuar estudiando conceptos más avanzados de la Programación Orientada a Objetos, como **herencia, polimorfismo, abstracción, interfaces y composición**.

---

<div align="center">

## Laboratorio #2 · Orientación a Objetos

**Clases en C#**

<br>

<img src="https://img.shields.io/badge/Made%20with-C%23-239120?style=for-the-badge&logo=csharp&logoColor=white" alt="Made with C#">

<br><br>

*Desarrollado como parte de las actividades académicas de la asignatura.*

</div>
