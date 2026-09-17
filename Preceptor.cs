using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeAlumnos
{
    public class Preceptor : Persona
    {
        public Preceptor(string nombre, int legajo)
            : base(nombre, legajo)
        {
        }

        public override string Presentarse()
        {
            return $"Hola, soy {Nombre} y soy preceptor.";
        }
    }
}
