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
            catch (Exception ex)
            {

                Session.Add("error", ex);
                Response.Redirect("Error.aspx", false);
            }
        }
    }
}