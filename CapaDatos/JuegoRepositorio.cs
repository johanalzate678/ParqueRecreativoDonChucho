using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class JuegoRepositorio
    {
        private readonly string cadena =ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
        private string sql = "";


        //Registrar
        public void RegistrarJuego(Juego a)
        {
            using (MySqlConnection cn = new MySqlConnection(cadena))
            {
                sql = @"INSERT INTO juego (CodigoJuego, Nombre, Duracion, Categoria)
                        VALUES (@CodigoJuego, @Nombre, @Duracion, @Categoria)";
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@CodigoJuego", a.CodigoJuego);
                cmd.Parameters.AddWithValue("@Nombre", a.Nombre);
                cmd.Parameters.AddWithValue("@Duracion", a.Duracion);
                cmd.Parameters.AddWithValue("@Categoria", a.Categoria);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }


        //Buscar
        public DataTable BuscarJuego(int id)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection coon = new MySqlConnection(cadena))
            {
                string sql = "SELECT * FROM juego WHERE CodigoJuego =@CodigoJuego";
                MySqlCommand cmd = new MySqlCommand(sql, coon);
                cmd.Parameters.AddWithValue("@CodigoJuego", id);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;

        }

        //Listar
        public DataTable ListarJuego()
        {
            DataTable dt = new DataTable();
            using (var coon = new MySqlConnection(cadena))
            {
                coon.Open();
                string sql = "SELECT * FROM juego";
                MySqlCommand cmd = new MySqlCommand(sql, coon);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;

        }
    }
}
