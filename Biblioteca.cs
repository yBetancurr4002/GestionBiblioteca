// Clase Biblioteca que implementa la interfaz IBiblioteca
public class Biblioteca : IBiblioteca
{

    public Dictionary<string, Libro> LibrosDisponibles { get; set; }
    public Dictionary<string, Usuario> Usuarios { get; set; }


    public Biblioteca()
    {
        LibrosDisponibles = new Dictionary<string, Libro>();
        Usuarios = new Dictionary<string, Usuario>();
    
        Libro primerLibro = new Libro(
            "Amor en los tiempos del cólera",
            "Gabriel García Márquez",
            "1985",
            true
        );

        Libro segundoLibro = new Libro(
            "Un tal Bernabé Bernal",
            "Álvaro Salom Becerra",
            "1988",
            true
        );

        Libro tercerLibro = new Libro(
            "Satanás",
            "Mario Mendoza",
            "2002",
            true
        );

        LibrosDisponibles.Add(primerLibro.Titulo, primerLibro);
        LibrosDisponibles.Add(segundoLibro.Titulo, segundoLibro);
        LibrosDisponibles.Add(tercerLibro.Titulo, tercerLibro);
    }

    public void MostrarCatalogo()
    {
        Console.WriteLine("Catálogo de libros disponibles:");
        
        foreach (var libro in LibrosDisponibles.Values)
        {
            var estaDisponible = libro.Activo ? "disponible" : "no disponible";
            Console.WriteLine($"Título: {libro.Titulo}, Autor: {libro.Autor}, Año de Publicación: {libro.AñoPublicacion}, Disponible: {estaDisponible}");
        }
    }

    public void AgregarUsuario(string nombreUsuario)
    {
        Usuario usuario = new Usuario(nombreUsuario);
        Usuarios.Add(nombreUsuario, usuario);
    }

    public void PrestarLibro(string tituloLibro, string nombreUsuario)
    {
        Libro libroAPrestar = LibrosDisponibles[tituloLibro];

        if (libroAPrestar.Activo && Usuarios.ContainsKey(nombreUsuario))
        {
            Console.WriteLine($"El libro '{tituloLibro}' ha sido prestado a '{nombreUsuario}'.");
            libroAPrestar.Activo = false;
            
        }
        else if(!Usuarios.ContainsKey(nombreUsuario))
        {
            Console.WriteLine("No se puede prestar, el usuario no encontrado");
        }
        else
        {
            Console.WriteLine("No se puede prestar el libro, libro no disponible.");
        }
    }

public void DevolverLibro(string tituloLibro)
{
    Libro libroADevolver = LibrosDisponibles[tituloLibro];
    if (libroADevolver.Activo)
    {
        Console.WriteLine($"El libro '{tituloLibro}' ya está disponible en la biblioteca.");
    }
    else
    {
        libroADevolver.Activo = true;
        Console.WriteLine($"El libro '{tituloLibro}' ha sido devuelto a la biblioteca.");
    }
}


}
