using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class AtraccionRepositorio
    {
        private readonly string cadena = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
        private string sql = "";

        //Registrar
        public void RegistrarAtraccion(Atraccion a)
        {
            using (MySqlConnection cn = new MySqlConnection(cadena))
            {
                sql = @"INSERT INTO Atraccion (CodigoAtraccion, Nombre, PrecioEntrada, CapacidadMaxima)
                        VALUES (@CodigoAtraccion, @Nombre, @PrecioEntrada, @CapacidadMaxima)";
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@CodigoAtraccion", a.CodigoAtraccion);
                cmd.Parameters.AddWithValue("@Nombre", a.Nombre);
                cmd.Parameters.AddWithValue("@PrecioEntrada", a.PrecioEntrada);
                cmd.Parameters.AddWithValue("@CapacidadMaxima", a.CapacidadMaxima);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //Actualizar

        public void ActualizarAtraccion(Atraccion a)
        {
            using (MySqlConnection cn = new MySqlConnection(cadena))
            {
                sql = @"UPDATE Atraccion SET Nombre=@Nombre,PrecioEntrada=@PrecioEntrada, CapacidadMaxima=@CapacidadMaxima
                                          WHERE CodigoAtraccion =@CodigoAtraccion;";
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@CodigoAtraccion", a.CodigoAtraccion);
                cmd.Parameters.AddWithValue("@Nombre", a.Nombre);
                cmd.Parameters.AddWithValue("@PrecioEntrada", a.PrecioEntrada);
                cmd.Parameters.AddWithValue("@CapacidadMaxima", a.CapacidadMaxima);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //Buscar

        public DataTable BuscarAtraccion(int id )
        {
            DataTable dt = new DataTable();
            using (MySqlConnection coon = new MySqlConnection(cadena))
            {
                string sql = "SELECT * FROM atraccion WHERE CodigoAtraccion =@CodigoAtraccion";
                MySqlCommand cmd = new MySqlCommand( sql, coon );
                cmd.Parameters.AddWithValue("@CodigoAtraccion",id);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;

        }
        //Listar

        public DataTable ListarAtraccion()
        {
            DataTable dt = new DataTable();
            using (var coon = new MySqlConnection(cadena))
            {
                coon.Open();
                string sql = "SELECT * FROM atraccion";
                MySqlCommand cmd = new MySqlCommand(sql, coon);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;

        }

    }
}
