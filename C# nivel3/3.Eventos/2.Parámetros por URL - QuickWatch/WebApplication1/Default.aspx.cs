using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Aca usamos postBack para preguntar si estamos en frente de la primera carga.
            if (!IsPostBack)
            {
                txtNombre.Text = "Ingrese su nombre: ";
            }
            // Porque cada vez hago CLICK en el evento Agregar pasa siempre por el page load.
        }

        protected void txtNombre_TextChanged(object sender, EventArgs e)
        {
            lblSecundario.Text = "Hola como estas" + txtNombre.Text;
        }

        protected void btnButton_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            lblSaludo.Text = "Hola como estas" + nombre;

            // parametros por url.
            Response.Redirect("About.aspx?nombre=" + nombre, false);
        }
    }
}