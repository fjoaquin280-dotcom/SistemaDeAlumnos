using SistemaDeAlumnos;

Alumno alumno1 = new Alumno();

alumno1.Nombre = "Joaquin";
alumno1.Legajo = 123;
alumno1.Nota1 = 8.5;
alumno1.Nota2 = 7.0;

Alumno alumno2 = new Alumno();
alumno2.Nombre = "Sofia";
alumno2.Legajo = 456;
alumno2.Nota1 = 9.0;
alumno2.Nota2 = 10.0;

// Mostrar nombre y legajo
Console.WriteLine($"{alumno1.Nombre} - {alumno1.Legajo}");
Console.WriteLine($"{alumno2.Nombre} - {alumno2.Legajo}");

alumno1.Nombre = "Pedro";

Console.WriteLine("\nDespués del cambio:");
Console.WriteLine($"{alumno1.Nombre} - {alumno1.Legajo}");
Console.WriteLine($"{alumno2.Nombre} - {alumno2.Legajo}");