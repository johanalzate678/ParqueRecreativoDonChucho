using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class Atraccion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private readonly CN_Atraccion atraccion = new CN_Atraccion();
        protected void btnRegistrarAtraccion_Click(object sender, EventArgs e)
        {
            atraccion.Insertar(int.Parse(txtCodigoAtraccion.Text), txtNombreAtraccion.Text, int.Parse(txtPrecioEntrada.Text), txtCapacidadMaxima.Text);
        }

        protected void btnListarAtracciones_Click(object sender, EventArgs e)
        {

            gvAtracciones.DataSource = atraccion.listar();
            gvAtracciones.DataBind();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            atraccion.Actualizar(int.Parse(txtCodigoActualizar.Text), txtNuevoNombre.Text, int.Parse(txtNuevoPrecio.Text), txtNuevaCapacidad.Text);
        }

        protected void btnBuscarAtraccion_Click1(object sender, EventArgs e)
        {
            int id = int.Parse(txtBuscarAtraccion.Text);
            dgvBuscarAtraccion.DataSource = atraccion.buscar(id);
            dgvBuscarAtraccion.DataBind();
        }
    }
}