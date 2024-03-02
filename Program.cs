// Creas una instancia de la biblioteca
Biblioteca miBiblioteca = new Biblioteca();

// Mostrar catálogo
miBiblioteca.MostrarCatalogo();

//Agregar Usuarios
miBiblioteca.AgregarUsuario("Yeison Betancur");
miBiblioteca.AgregarUsuario("Remi");


miBiblioteca.PrestarLibro("Satanás", "Yeison Betancur");
miBiblioteca.PrestarLibro("Satanás", "Remi");
miBiblioteca.MostrarCatalogo();

miBiblioteca.DevolverLibro("Satanás");

miBiblioteca.PrestarLibro("Satanás", "Remi");

