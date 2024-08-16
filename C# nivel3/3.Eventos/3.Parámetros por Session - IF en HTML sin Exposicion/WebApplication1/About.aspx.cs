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
        public string user { get; set; } // creo una propiedad para obtener o captar este valor.
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

            //user = Request.QueryString["nombre"] != null ? Request.QueryString["nombre"].ToString() : "";

            //3 PASO PARA PASAR PARAMETRO POR VALOR, SIN QUE SE VEA EN LA URL.
            // podemos ver con inspecio rapida, datos que llegan Seleccionado Session["usuario], y inspeccionar.
            user = Session["usuario"] != null ? Session["usuario"].ToString() : ""; ;
            lblNombre.Text = user + "Tu ingreso fue exisito";
        }
    }
}