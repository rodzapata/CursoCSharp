using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arrays
{
    public class Empleado
    {
        public string Nombre { get; }
        public int Edad { get; }

        public Empleado(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

    }
}