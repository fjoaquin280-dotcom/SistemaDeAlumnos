using SistemaDeAlumnos;

Alumno alumno1 = new Alumno("Joaquin", 123);
Alumno alumno2 = new Alumno("Sofia", 456);

if (!alumno1.CargarNotas(8.5, 7.0))
{
    Console.WriteLine("Notas inválidas para Joaquin");
}

if (!alumno2.CargarNotas(4.0, 5.0))
{
    Console.WriteLine("Notas inválidas para Sofia");
}
//alumno1.Nota1 = 47;
// CS0272
//La propiedad o el indizador 'Alumno.Nota1' no se pueden usar en este contexto porque el descriptor de acceso set es inaccesible

//Alumno alumno3 = new Alumno();

// CS7036: No se ha dado ningún argumento que corresponda al parámetro requerido 'nombre' de 'Alumno.Alumno(string, int, double, double)'.

// Al intentar crear un objeto con new Alumno() aparece el error CS7036 porque la clase
// Alumno tiene un constructor que requiere cuatro parámetros (nombre, legajo, nota1 y
// nota2). Como no se envía ningún argumento, el compilador no encuentra un constructor compatible y muestra el error.

// Mostrar nombre y legajo
Console.WriteLine($"{alumno1.Nombre}: {alumno1.Promedio()}");
Console.WriteLine($"{alumno2.Nombre}: {alumno2.Promedio()}");

Console.WriteLine($"{alumno1.Nombre} aprobado: {alumno1.EstaAprobado()}");
Console.WriteLine($"{alumno2.Nombre} aprobado: {alumno2.EstaAprobado()}");

alumno1.SubirNota();
alumno2.SubirNota();

Console.WriteLine("Después de subir la nota:");
Console.WriteLine($"{alumno1.Nombre}: {alumno1.Promedio()}");
Console.WriteLine($"{alumno2.Nombre}: {alumno2.Promedio()}");

Console.WriteLine(alumno1);
Console.WriteLine(alumno2);