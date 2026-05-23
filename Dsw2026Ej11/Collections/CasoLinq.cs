

using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    private List<Libro> listaLibros;

    public CasoLinq() 
    {
        listaLibros = Libro.CrearLista();
    }

    public Libro GetPrimero()
    {
        return listaLibros.First();
    }

    public Libro GetUltimo()
    {
        return listaLibros.Last();
    }

    public decimal GetTotalPrecios()
    {
        return listaLibros.Sum(libro => libro.Precio);
    }

   public decimal GetPromedioPrecios()
    {
        return listaLibros.Average(libro => libro.Precio);
    }

    public List<Libro> GetListById()
    {
        return listaLibros.Where(libro => libro.Id > 15).ToList();
    }

    public List<string> GetLibros()
    {
        return listaLibros.Select(libro => $"{libro.Titulo} - {libro.Precio:C}").ToList();
    }

    public Libro GetMayorPrecio()
    {
        return listaLibros.OrderByDescending(libro => libro.Precio).First();
    }

    public Libro GetMenorPrecio()
    {
        return listaLibros.OrderBy(libro => libro.Precio).First();
    }

    public List<Libro> GetMayorPromedio()
    {
        decimal promedio = listaLibros.Average(libro => libro.Precio);

        return listaLibros.Where(libro => libro.Precio > promedio).ToList();
    }

    public List<Libro> GetLibrosDescendente()
    {
        return listaLibros.OrderByDescending(libro => libro.Titulo).ToList();
    }
}
