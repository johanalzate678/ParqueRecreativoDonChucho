using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CapaNegocio
{
    public class CN_Sesion
    {
        private SesionRepositorio Sesion = new SesionRepositorio();

        public void RegistrarSesion(int codigoAtraccion, int codigoJuego, string numeroZona, string horaInicio, string boletosVendidos)
        {
            Sesion.InsertarSesion(codigoAtraccion, codigoJuego, numeroZona, horaInicio, boletosVendidos);
        }

        public DataTable listar()
        {
            return Sesion.ListarSesion();
        }
    }
}
