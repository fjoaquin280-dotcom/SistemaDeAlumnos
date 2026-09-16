using SistemaDeAlumnos;

Alumno alumno1 = new Alumno("Joaquin", 123, 8.5, 7.0);

Alumno alumno2 = new Alumno("Sofia", 456, 9.0, 10.0);

Alumno alumno3 = new Alumno();
// Mostrar nombre y legajo
Console.WriteLine($"{alumno1.Nombre} - {alumno1.Legajo}");
Console.WriteLine($"{alumno2.Nombre} - {alumno2.Legajo}");

alumno1.Nombre = "Pedro";

Console.WriteLine("\nDespués del cambio:");
Console.WriteLine($"{alumno1.Nombre} - {alumno1.Legajo}");
Console.WriteLine($"{alumno2.Nombre} - {alumno2.Legajo}");