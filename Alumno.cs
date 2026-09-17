using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeAlumnos
{
    public class Alumno : Persona, IExportable
    {
        public string ExportarLinea()
        {
            return $"ALUMNO;{Legajo};{Nombre};{Promedio()}";
        }
        public double Nota1 { get; private set; }
        public double Nota2 { get; private set; }

        public Alumno(string nombre, int legajo)
            : base(nombre, legajo)
        {
        }

        public double Promedio()
        {
            return (Nota1 + Nota2) / 2;
        }

        public bool EstaAprobado()
        {
            return Promedio() >= 6;
        }

        public void SubirNota()
        {
            if (Nota1 < 10)
                Nota1++;

            if (Nota2 < 10)
                Nota2++;
        }

        public override string ToString()
        {
            return $"{Legajo} - {Nombre} (promedio: {Promedio()})";
        }
        //Al quitar override, el compilador indica que ToString() oculta un método heredado de Object.
        //La palabra override sirve para reemplazar correctamente el método heredado.

        public bool CargarNotas(double nota1, double nota2)
        {
            if (nota1 < 0 || nota1 > 10 || nota2 < 0 || nota2 > 10)
            {
                return false;
            }

            Nota1 = nota1;
            Nota2 = nota2;

            return true;
        }
        public override string Presentarse()
        {
            return $"Hola, soy {Nombre}, alumno con legajo {Legajo}.";
        }
    }
}