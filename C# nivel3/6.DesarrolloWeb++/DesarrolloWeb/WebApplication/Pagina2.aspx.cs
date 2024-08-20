using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class Pagina2 : System.Web.UI.Page
    {
        //7.Login y PermisosPágina
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Session["usuario"] != null && ((dominio.Usuario)Session["usuario"]).TipoUser == dominio.TipoUsuario.ADMIN))
            {
                Session.Add("error", "Debes loguearte como Admin para ingresar a esta Pagina");
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login2.aspx", false);
        }
    }
}