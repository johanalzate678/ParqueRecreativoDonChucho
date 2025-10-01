using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
    public class CN_Juego
    {
        JuegoRepositorio juego = new JuegoRepositorio();

        public void Insertar (int CodigoJuego, string Nombre ,string Duracion , string Categoria )
        {
            Juego jg = new Juego
            {
                CodigoJuego = CodigoJuego,
                Nombre = Nombre,
                Duracion = Duracion,
                Categoria = Categoria
            };
            juego.RegistrarJuego(jg);
        }

        public DataTable buscar(int CodigoJuego) 
        { 
            return juego.BuscarJuego(CodigoJuego);
        }

        public DataTable listar()
        {
            return juego.ListarJuego();
        }

    }
}
