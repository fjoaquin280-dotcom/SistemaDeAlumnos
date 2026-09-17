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

List<Alumno> alumnos = new List<Alumno>();

int opcion;

do
{
    Console.WriteLine("\n--- MENU ---");
    Console.WriteLine("1. Agregar alumno");
    Console.WriteLine("2. Listar alumnos");
    Console.WriteLine("3. Buscar alumno por legajo");
    Console.WriteLine("4. Mostrar promedio general");
    Console.WriteLine("5. Mostrar alumnos aprobados");
    Console.WriteLine("6. Salir");

    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Legajo: ");
            int legajo = int.Parse(Console.ReadLine());

            Console.Write("Nota 1: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Nota 2: ");
            double nota2 = double.Parse(Console.ReadLine());

            Alumno nuevoAlumno = new Alumno(nombre, legajo);

            if (nuevoAlumno.CargarNotas(nota1, nota2))
            {
                alumnos.Add(nuevoAlumno);
                Console.WriteLine("Alumno agregado.");
            }
            else
            {
                Console.WriteLine("Notas inválidas.");
            }

            break;
        case 2:

            foreach (Alumno a in alumnos)
            {
                Console.WriteLine(a);
            }
            break;

        case 3:

            Console.Write("Legajo a buscar: ");
            int legajoBuscado = int.Parse(Console.ReadLine());

            bool encontrado = false;

            foreach (Alumno a in alumnos)
            {
                if (a.Legajo == legajoBuscado)
                {
                    Console.WriteLine(a);
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Alumno no encontrado.");
            }
            break;

        case 4:

            if (alumnos.Count == 0)
            {
                Console.WriteLine("No hay alumnos.");
            }
            else
            {
                double suma = 0;

                foreach (Alumno a in alumnos)
                {
                    suma += a.Promedio();
                }

                Console.WriteLine($"Promedio general: {suma / alumnos.Count}");
            }
            break;

        case 5:

            int aprobados = 0;

            foreach (Alumno a in alumnos)
            {
                if (a.EstaAprobado())
                {
                    aprobados++;
                }
            }

            Console.WriteLine($"Aprobados: {aprobados}");
            break;

        default:

            Console.WriteLine("Opción inválida.");

            break;

    }

} while (opcion != 6);

List<IExportable> exportables = new List<IExportable>();

Alumno alumnoExport = new Alumno("Ana Pérez", 1234);
alumnoExport.CargarNotas(7, 7);

Profesor profesorExport = new Profesor("Marta Díaz", 5678, "Programación");

Materia materia1 = new Materia("PROG1", "Programación I", 128);
Materia materia2 = new Materia("MAT1", "Matemática I", 96);

exportables.Add(alumnoExport);
exportables.Add(profesorExport);
exportables.Add(materia1);
exportables.Add(materia2);

foreach (IExportable item in exportables)
{
    Console.WriteLine(item.ExportarLinea());
}