using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeAlumnos
{
    public interface IExportable
    {
        string ExportarLinea();
        // string ExportarEncabezado();
        //Las clases que implementan una interfaz están obligadas a implementar
        //todos los métodos declarados por la interfaz. Al agregar ExportarEncabezado()
        //5aparecen errores porque ninguna de las clases lo implementa.
    }
}

