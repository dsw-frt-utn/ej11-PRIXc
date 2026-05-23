using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
using System.Numerics;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList gestor = new CasoList();

        Alumno alumno1 = new Alumno(1, "Ana", 8.5);

        Alumno alumno2 = new Alumno(2, "Carlos", 7.0);

        Alumno alumno3 = new Alumno(3, "Beatriz", 9.2);

        gestor.AgregarAlumno(alumno1);
        gestor.AgregarAlumno(alumno2);
        gestor.AgregarAlumno(alumno3);

        Console.WriteLine("\n--- Lista de alumnos ---");

        foreach (Alumno a in gestor.RetornarLista())
        { 
            Console.WriteLine(a.ToString());
        }

        Console.WriteLine("\n--- Buscando alumno que existe (Carlos) ---");

        Alumno alumnoExistente = gestor.BuscarAlumnoPorNombre("Carlos");

        if (alumnoExistente != null)
        {
            Console.WriteLine(alumnoExistente.ToString());
        }

        Console.WriteLine("\n--- Buscando alumno que no existe (Pedro) ---");

        Alumno alumnoInexistente = gestor.BuscarAlumnoPorNombre("Pedro");

        if (alumnoInexistente == null)
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("\n--- Eliminando a Carlos ---");

        gestor.EliminarAlumno(alumno2);

        foreach (Alumno a in gestor.RetornarLista())
        {
            Console.WriteLine(a.ToString());
        }

        Console.WriteLine("\n--- Eliminando el primer elemento de la lista ---");
       
        gestor.EliminarAlumnoPosicion(0);

        foreach (Alumno a in gestor.RetornarLista())
        {
            Console.WriteLine(a.ToString());
        }
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
       
    CasoDictionary gestor = new CasoDictionary();

        
        Alumno alumno1 = new Alumno(1, "Ana", 8.5);
        Alumno alumno2 = new Alumno(2, "Carlos", 7.0);
        Alumno alumno3 = new Alumno(3, "Beatriz", 9.2);

        gestor.AgregarAlumno(1, alumno1);
        gestor.AgregarAlumno(2, alumno2);
        gestor.AgregarAlumno(3, alumno3);

        
        Console.WriteLine("\n--- Lista de alumnos en el Diccionario ---");
       
        foreach (KeyValuePair<int, Alumno> par in gestor.RetornarDiccionario())
        {
            Console.WriteLine($"Legajo: {par.Key} -> Datos: {par.Value.ToString()}");
        }

        
        Console.WriteLine("\n--- Buscando alumno con legajo 2 (Existe) ---");
        
        Alumno alumnoExistente = gestor.BuscarAlumno(2);

        if (alumnoExistente != null)
        {
            Console.WriteLine(alumnoExistente.ToString());
        }

        
        Console.WriteLine("\n--- Buscando alumno con legajo 99 (No existe) ---");

        Alumno alumnoInexistente = gestor.BuscarAlumno(99);

        if (alumnoInexistente == null)
        {
            Console.WriteLine("No existe");
        }

        
        Console.WriteLine("\n--- Eliminando al alumno con legajo 1 ---");

        gestor.EliminarAlumno(1);

        Console.WriteLine("\n--- Lista de alumnos actualizada ---");
       
        foreach (Alumno a in gestor.RetornarDiccionario().Values)
        {
            Console.WriteLine(a.ToString());
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq gestorLinq = new CasoLinq();

        
        Console.WriteLine("--- 1. Primer Libro ---");

        Libro primerLibro = gestorLinq.GetPrimero();

        Console.WriteLine($"Id: {primerLibro.Id} - {primerLibro.Titulo} - Precio: {primerLibro.Precio:C}");

        
        Console.WriteLine("\n--- 2. Último Libro ---");

        Libro ultimoLibro = gestorLinq.GetUltimo();

        Console.WriteLine($"Id: {ultimoLibro.Id} - {ultimoLibro.Titulo} - Precio: {ultimoLibro.Precio:C}");

       
        Console.WriteLine("\n--- 3. Suma Total de Precios ---");

        decimal totalPrecios = gestorLinq.GetTotalPrecios();

        Console.WriteLine($"El valor total del inventario es: {totalPrecios:C}");

        
        Console.WriteLine("\n--- 4. Promedio de Precios ---");

        decimal promedioPrecios = gestorLinq.GetPromedioPrecios();

        Console.WriteLine($"El precio promedio de los libros es: {promedioPrecios:C}");

        
        Console.WriteLine("\n--- 5. Libros con Id mayor a 15 ---");
        
        foreach (Libro libro in gestorLinq.GetListById())
        {
            Console.WriteLine($"Id: {libro.Id} - {libro.Titulo}");
        }

        
        Console.WriteLine("\n--- 6. Lista de Libros (Título y Precio) ---");
       
        foreach (string infoLibro in gestorLinq.GetLibros())
        {
            Console.WriteLine(infoLibro);
        }

        
        Console.WriteLine("\n--- 7. Libro con el Precio Más Alto ---");

        Libro mayorPrecio = gestorLinq.GetMayorPrecio();

        Console.WriteLine($"{mayorPrecio.Titulo} con un precio de {mayorPrecio.Precio:C}");

        
        Console.WriteLine("\n--- 8. Libro con el Precio Más Bajo ---");

        Libro menorPrecio = gestorLinq.GetMenorPrecio();

        Console.WriteLine($"{menorPrecio.Titulo} con un precio de {menorPrecio.Precio:C}");

        
        Console.WriteLine("\n--- 9. Libros con Precio Mayor al Promedio ---");

        foreach (Libro libro in gestorLinq.GetMayorPromedio())
        {
            Console.WriteLine($"{libro.Titulo} - {libro.Precio:C}");
        }

        
        Console.WriteLine("\n--- 10. Libros Ordenados por Título (Descendente) ---");

        foreach (Libro libro in gestorLinq.GetLibrosDescendente())
        {
            Console.WriteLine($"- {libro.Titulo}");
        }
    }
}
