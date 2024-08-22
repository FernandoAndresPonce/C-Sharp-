using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Helper;
using Dominio;

namespace WebApp
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        public Usuario usu { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {

            usu = (Usuario)Session["Usuario"];

            //<% --[5.Login]-- %> y esto lo repito en cada pantalla para validar, y no puedan ingresar
            //por la URL poniendo la redireccion para validar nuestra seguridad.

            if (!(Page is Login || Page is Default || Page is Registrarse))
            {

                if (!Seguridad.sessionActiva(Session["Usuario"]))
                {
                    Session.Add("error", "Debes logearte");
                    Response.Redirect("Login.aspx", false);
                }
                else
                {   //<% --[7.Login]
                    if(Page is ListaPokemon)
                        if (!(Seguridad.esAdmin(Session["Usuario"])))
                        {
                            Session.Add("error", "Admin para ingresar aqui");
                            Response.Redirect("Error.aspx", false);
                        }
                 

                    

                }
            }





        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx", false);
        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registrarse.aspx", false);
        }

        protected void btnPerfil_Click(object sender, EventArgs e)
        {
            Response.Redirect("MiPerfil.aspx", false);
        }
    }
}