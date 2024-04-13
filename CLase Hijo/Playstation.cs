using Ejemplo.Clase_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.CLase_Hijo
{
    internal class Playstation : ClsConsola

    {
        public string ModeloControlador { get; set; }
        public string MostrarDetallesPS()
        {
            MostrarDetalles();
            return $"Modelo de Controlador:{ModeloControlador}";
        }
    }
}
