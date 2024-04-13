using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.Clase_Base
{
    internal class ClsConsola
    {
        public string Marca { get; set; }
        public int AnioLanzamineto { get; set; }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Marca:{Marca}, año lanzamiento:{AnioLanzamineto}");
        }
    }
}
