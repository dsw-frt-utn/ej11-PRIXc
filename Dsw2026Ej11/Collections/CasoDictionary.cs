

using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private Dictionary<int, Alumno> diccionarioAlumnos;

public CasoDictionary()
    {
        diccionarioAlumnos = new Dictionary<int, Alumno>();
    }

    public void AgregarAlumno(int legajo, Alumno alumno)
    {
        if(!diccionarioAlumnos.ContainsKey(legajo))
        {
            diccionarioAlumnos.Add(legajo, alumno);
        }
        else
        {
            Console.WriteLine("El legajo ya existe.");
        }
    }
    public Alumno BuscarAlumno(int legajo)
    {
        if (diccionarioAlumnos.ContainsKey(legajo))
        {
            return diccionarioAlumnos[legajo];
        }
        Console.WriteLine("El alumno no se encontro");
        return null;
    }
    public bool EliminarAlumno(int legajo)
    {
        bool eliminado = diccionarioAlumnos.Remove(legajo);

        if (eliminado)
        {
            Console.WriteLine("Alumno eliminado correctamente");
        }
        else
        {
            Console.WriteLine("No se elimino, el legajo no existe");
        }

        return eliminado;
    }
    public Dictionary<int, Alumno> RetornarDiccionario()
    {
        return diccionarioAlumnos;
    }

}
