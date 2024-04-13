using Ejemplo.Clase_Base;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.CLase_Hijo
{
    internal class Xbox : ClsConsola
    {
        public string TipoGamepass { get; set; }
        public string MostrarDetallesXB()
        {
            MostrarDetalles();
            return $"Tipo de Susbcripcion:{TipoGamepass}";
        }
    }
}
