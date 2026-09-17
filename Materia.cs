using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeAlumnos
{
    public class Materia : IExportable
    {
        public string ExportarLinea()
        {
            return $"MATERIA;{Codigo};{Nombre};{CantidadHoras}";
        }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int CantidadHoras { get; set; }

        public Materia(string codigo, string nombre, int cantidadHoras)
        {
            Codigo = codigo;
            Nombre = nombre;
            CantidadHoras = cantidadHoras;
        }
    }
}
