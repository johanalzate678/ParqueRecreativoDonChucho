using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class Sesion : System.Web.UI.Page
    {
       private readonly CN_Sesion sesion = new CN_Sesion();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrarS_Click(object sender, EventArgs e)
        {
            sesion.RegistrarSesion(int.Parse(txtCodigoAtraccion.Text), int.Parse(txtCodigoJuego.Text), txtNumeroZona.Text, txtHoraInicio.Text , txtBoletos.Text);
        }

        protected void btnListarS_Click(object sender, EventArgs e)
        {
            gvSesiones.DataSource = sesion.listar();
            gvSesiones.DataBind();
        }
    }
}