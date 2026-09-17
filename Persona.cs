using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeAlumnos
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Legajo { get; set; }

        public Persona(string nombre, int legajo)
        {
            Nombre = nombre;
            Legajo = legajo;
        }
    }
}
