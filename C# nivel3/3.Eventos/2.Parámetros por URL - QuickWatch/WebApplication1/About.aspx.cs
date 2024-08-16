using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // y aca carpturamos el valor de la url, ese parametro.

            //if (Request.QueryString["nombre"] != null)
            //{
            //    string user = Request.QueryString["nombre"].ToString(); // porque esto me devuelve un objeto
            //    txtNombre.Text = user + "tu ingreso fue exitoso";
            //}

            // Otra forma de escribir un IF ES UNA SOLA LINEA.
            //           =          si esto  es distinto de nulo ? devolvemos  esto                         : sino esto;
            string user = Request.QueryString["nombre"] != null ? Request.QueryString["nombre"].ToString() : "Logueate";
            lblNombre.Text = user;
        }
    }
}