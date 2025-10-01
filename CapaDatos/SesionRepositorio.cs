using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class SesionRepositorio
    {
        private readonly string cadena = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
        private string sql = "";
        //RegistrarSesiones

        public void InsertarSesion(int codigoAtraccion, int codigoJuego, int numeroZona, DateTime horaInicio, int boletosVendidos)
        {
            using (MySqlConnection conn = new MySqlConnection(cadena))
            {
                conn.Open();
                string query = "INSERT INTO sesion (CodigoAtraccion, CodigoJuego, NumeroZona, HoraInicio, BoletosVendidos) " +
                               "VALUES (@codigoAtraccion, @codigoJuego, @numeroZona, @horaInicio, @boletosVendidos)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@codigoAtraccion", codigoAtraccion);
                cmd.Parameters.AddWithValue("@codigoJuego", codigoJuego);
                cmd.Parameters.AddWithValue("@numeroZona", numeroZona);
                cmd.Parameters.AddWithValue("@horaInicio", horaInicio);
                cmd.Parameters.AddWithValue("@boletosVendidos", boletosVendidos);

                cmd.ExecuteNonQuery();
            }
        }
        //
    }
}
