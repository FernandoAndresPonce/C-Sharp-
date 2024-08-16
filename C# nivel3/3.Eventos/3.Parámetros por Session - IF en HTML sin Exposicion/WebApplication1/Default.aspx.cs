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
                txtContrasena.Text = "ingrese contrasena";
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
            string contrasena = txtContrasena.Text;
            lblSaludo.Text = "Hola como estas" + nombre;
            // 2 PASO  Sesion es un objeto vivo.
            // LO PUEDO USAR EN CUALQUIER PANTALLAS ESTOS VALORES, SE GUARDA EN EL SERVIDOR
            Session.Add("usuario", nombre);
            Session.Add("pass", contrasena);

            // parametros por url, pero para pasar MAS DE UN PARAMETRO EN ESTE CASO CONSTRASENIA
            // y usamos ademas del ? para el primer paramtro para elsiguente el &

            //Response.Redirect("About.aspx?nombre=" + nombre + "&contrasena=" + txtContrasena.Text, false);

            // 1 PASO para que no aparzcan LOS PARAMETROS , LAS VARIABLES QUE NECESITAMOS EN OTRA PAGINA.
            Response.Redirect("About.aspx", false);
        }
    }
}