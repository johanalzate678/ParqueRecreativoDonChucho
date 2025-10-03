using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Sesion
    {
        
        public int CodigoAtraccion { get; set; }
        public int CodigoJuego { get; set; }
        public string NumeroZona { get; set; }
        public string HoraInicio { get; set; }
        public string BoletosVendidos { get; set; }

        public Sesion() { }
    }
}
