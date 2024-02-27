// Interfaz para la biblioteca
public interface IBiblioteca
{
    void PrestarLibro(string titulo, string nombreUsuario);
    void DevolverLibro(string titulo);
    void MostrarCatalogo();
}