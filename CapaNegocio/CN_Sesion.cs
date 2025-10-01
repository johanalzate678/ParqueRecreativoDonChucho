using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
    public class CN_Sesion
    {
        private SesionRepositorio Sesion = new SesionRepositorio();

        public void RegistrarSesion(int codigoAtraccion, int codigoJuego, int numeroZona, DateTime horaInicio, int boletosVendidos)
        {
            Sesion.InsertarSesion(codigoAtraccion, codigoJuego, numeroZona, horaInicio, boletosVendidos);
        }


    }
}
