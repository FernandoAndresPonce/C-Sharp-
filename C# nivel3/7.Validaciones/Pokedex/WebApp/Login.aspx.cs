using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicaNegocio;
using Dominio;

namespace WebApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {

            //<% --[2.Login]-- %>
            NegocioUsuario negocio = new NegocioUsuario();
            Usuario usuarioLogin = new Usuario();
            try
            {
                //Validaciones.

                if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    Session.Add("error", "Debes completar los campos vacio");
                    Response.Redirect("Error.aspx");
                }
               

                usuarioLogin.Email = txtEmail.Text;
                usuarioLogin.Password = txtPassword.Text;


                if (negocio.Login(usuarioLogin))
                {
                    //<% --[4.Login]-- %>
                    Session.Add("Usuario", usuarioLogin);
                    Response.Redirect("MiPerfil.aspx", false);
                }
                else
                {
                    Response.Redirect("Error.aspx", false);
                    Session.Add("error", "User o Password Incorrectos");

                }


            }
            //Validacion
            catch(System.Threading.ThreadAbortException ex) { }

            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }
        }

        //.o Manejo de Errores Genérico, este manejon de error, el otro es global, y este es mas especifico,
        //captura el error solamente de esta pagina, si es que no se crea un try catch.
        private void Page_Error(object sender, EventArgs e)
        {
            Exception exc = Server.GetLastError();
            Session.Add("error", exc.Message);
            Server.Transfer("Error.aspx", true);

        }
    }
}