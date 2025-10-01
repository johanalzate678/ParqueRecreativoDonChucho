using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Atraccion
    {
        public int CodigoAtraccion {  get; set; }
        public string Nombre { get; set; }
        public int PrecioEntrada { get; set; }
        public string CapacidadMaxima { get; set; }

        public Atraccion() { }
    }
}
