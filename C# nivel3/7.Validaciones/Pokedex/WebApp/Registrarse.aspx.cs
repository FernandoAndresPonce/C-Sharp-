using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using LogicaNegocio;
using Service;

namespace WebApp
{
    public partial class Registrarse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {

        }

        //<%-- [1.Registro Trainee - output SQL - MailTrap]--%>
        protected void btnRegistrarse_Click1(object sender, EventArgs e)
        {

            try
            {
                Usuario usuario = new Usuario();
                NegocioUsuario negocio = new NegocioUsuario();
                EmailService servicio = new EmailService();
                
                
                usuario.Email = txtEmail.Text;
                usuario.Password = txtPassword.Text;

                //<%-- [5.Registro Trainee - output SQL - MailTrap]--%>
                usuario.Id = negocio.InsertarNuevo(usuario);
                //ver OJOOOOO
                Session.Add("Usuario", usuario);

                //<%-- [8.Registro Trainee - output SQL - MailTrap]--%
                servicio.ArmarCorreo(usuario.Email, "Bienvenido Trainer", "Hola te damos la bienvenida a la App.");
                servicio.enviarEmail();
                Response.Redirect("Default.aspx", false);
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
            }
        }
    }
}