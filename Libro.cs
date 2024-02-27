// Clase Libro
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string AñoPublicacion { get; set; }
    public bool Activo { get; set; }

    public Libro(string titulo, string autor, string añoPublicacion, bool activo)
    {
        Titulo = titulo;
        Autor = autor;
        AñoPublicacion = añoPublicacion;
        Activo = activo;

    }
    
}