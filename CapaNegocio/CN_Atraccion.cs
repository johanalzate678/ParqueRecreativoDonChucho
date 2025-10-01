using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CapaNegocio
{
    public class CN_Atraccion
    {
        AtraccionRepositorio atraccion = new AtraccionRepositorio();


        //insertar atraccion
        public void Insertar(int CodigoAtraccion, string Nombre, int PrecioEntrada, string CapacidadMaxima)
        {
            Atraccion at = new Atraccion
            {
                CodigoAtraccion = CodigoAtraccion,
                Nombre = Nombre,
                PrecioEntrada = PrecioEntrada,
                CapacidadMaxima = CapacidadMaxima
                
            };
            atraccion.RegistrarAtraccion(at);
        }
        //Actualizar atraccion
        public void Actualizar(int CodigoAtraccion, string Nombre, int PrecioEntrada, string CapacidadMaxima)
        {
            Atraccion at = new Atraccion
            {
                CodigoAtraccion = CodigoAtraccion,
                Nombre = Nombre,
                PrecioEntrada = PrecioEntrada,
                CapacidadMaxima = CapacidadMaxima

            };
            atraccion.ActualizarAtraccion(at);
        }




        //Buscar atraccion
        public DataTable buscar(int CodigoAtraccion)
        {
            return atraccion.BuscarAtraccion(CodigoAtraccion);
        }
        

        //Listar Atraccion
        public DataTable listar()
        {
            return atraccion.ListarAtraccion();
        }

    }
}
