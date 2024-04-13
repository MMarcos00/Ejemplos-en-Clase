using Ejemplo.Clase_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.CLase_Hijo
{
    internal class Nintendo : ClsConsola
    {
        public bool EsPortatil { get; set; }
        public string MostrarDetallesNintendo()
        {
            MostrarDetalles();
            return $"Es portatil: {EsPortatil}";
        }
    }
}
