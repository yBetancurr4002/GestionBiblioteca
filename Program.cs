// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Creas una instancia de la biblioteca
Biblioteca miBiblioteca = new Biblioteca();

// Mostrar catálogo
miBiblioteca.MostrarCatalogo();

//Agregar Usuarios
miBiblioteca.AgregarUsuario("Yeison Betancur");
miBiblioteca.AgregarUsuario("John Doe");


miBiblioteca.PrestarLibro("Satanás", "Yeison Betancur");
miBiblioteca.PrestarLibro("Satanás", "John Doe");

miBiblioteca.DevolverLibro("Satanás");
miBiblioteca.MostrarCatalogo();

miBiblioteca.PrestarLibro("Satanás", "John Doe");

