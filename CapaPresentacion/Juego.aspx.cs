using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class Juego : System.Web.UI.Page
    {
        private readonly CN_Juego juego = new CN_Juego();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            juego.Insertar(int.Parse(txtCodigo.Text), txtNom.Text, txtDuracion.Text, ddlCategoria.Text);
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBuscarCodigo.Text);
            dgvBuscarj.DataSource = juego.buscar(id);
            dgvBuscarj.DataBind();
        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            gvJuegos.DataSource = juego.listar();
            gvJuegos.DataBind();
        }
    }
}