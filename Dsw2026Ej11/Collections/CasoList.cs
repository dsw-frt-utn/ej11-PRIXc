using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private List<Alumno> listaAlumnos;

    public CasoList()
    {
        listaAlumnos = new List<Alumno>();

    }

    public void AgregarAlumno(Alumno alumno)
    {
        listaAlumnos.Add(alumno);
        Console.WriteLine("Se agrego el alumno a la lista");

    }

    public List<Alumno> RetornarLista()
    {
        return listaAlumnos;
    }

    public Alumno BuscarAlumnoPorNombre(string nombre)
    {
        Alumno alumnoEncontrado = listaAlumnos.Find(a => a.Nombre == nombre);

        if (alumnoEncontrado == null)
        {
            Console.WriteLine("no se encontro ningun alumno con ese nombre");
        }
        return alumnoEncontrado;
    }

    public void EliminarAlumno(Alumno alumno)
    {
        bool exito = listaAlumnos.Remove(alumno);

        if (exito)
        {
            Console.WriteLine("Se elimino al alumno de la lista");
        }
        else
        {
            Console.WriteLine("No se pudo eliminar: no existe en la lista");
        }
    }

    public void EliminarAlumnoPosicion(int posicion)
    {
        if (posicion >= 0 && posicion < listaAlumnos.Count)
        {
            listaAlumnos.RemoveAt(posicion);
            Console.WriteLine($"El alumno en la posicion {posicion} fue eliminado correctamente");
        }
        else
        {
            Console.WriteLine("La posicion indicada no es valida");
        }
    }
}
