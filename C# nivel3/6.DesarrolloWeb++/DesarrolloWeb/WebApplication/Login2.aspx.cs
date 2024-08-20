using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class Login2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //5.Login y PermisosPágina, esto lo hacemos, para que no puedan ingresar sin loguearte
            //con tan solo poniendo en el url, la direccion donde se encuentra el logueo.

            if(Session["usuario"] == null)
            {
                Session.Add("error", "Debes loguearte hermano para ingresar");
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void btnPagina1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagina1.aspx", false);
        }

        protected void btnPagina2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagina2.aspx", false);
        }
    }
}