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
        //public override string Presentarse()
        // Aparece un error porque los métodos marcados con override solo pueden sobrescribir
        // un método que sea virtual, abstract o override en la clase base.

        public virtual string Presentarse()
        {
            return $"Hola, soy {Nombre}.";
        }
    }
}
