using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejempl02
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnButton_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            lblNombre.Text = "Hola, como andas " + nombre;

            //Para con el Evento click a otra paginal, para que no se cancela la redireccion, porque podria
            //tirar excepcion este response.Rediret, se coloca el false.
            Response.Redirect("Formulario2.aspx", false);
        }
    }
}