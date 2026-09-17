using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeAlumnos
{
    public class Profesor : Persona, IExportable
    {
        public string ExportarLinea()
        {
            return $"PROFESOR;{Nombre};{Materia}";
        }

        public string Materia { get; set; }

        public Profesor(string nombre, int legajo, string materia)
            : base(nombre, legajo)
        {
            Materia = materia;
        }
        public override string Presentarse()
        {
            return $"Hola, soy {Nombre} y dicto {Materia}.";
        }
    }
}