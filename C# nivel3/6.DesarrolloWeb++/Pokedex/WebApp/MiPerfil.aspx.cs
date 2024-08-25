using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Helper;
using LogicaNegocio;
namespace WebApp
{
    public partial class MiPerfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                    if (Seguridad.sessionActiva(Session["Usuario"]))
                    {
                        Usuario user = (Usuario)Session["Usuario"];

                        txtEmail.Text = user.Email;
                        txtEmail.ReadOnly = true;
                        txtNombre.Text = user.Nombre;
                        txtApellido.Text = user.Apellido;
                        if(!string.IsNullOrEmpty(user.ImagenPerfil))
                            imgImagen.ImageUrl = "~/Images/"  + user.ImagenPerfil;

                    }


            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //<% --[2.Subir Imagen a Perfil]-- %>
            try
            {
                Usuario user = (Usuario)Session["Usuario"];
                NegocioUsuario negocio = new NegocioUsuario();
                //ESCRIBIR IMG
                //esto me devulve la ruta fisica de webapp , este donde este.
                string ruta = Server.MapPath("./Images/");
                txtImagenPerfil.PostedFile.SaveAs(ruta + "Perfil - " + user.Id + ".jpg");

                user.ImagenPerfil = "Perfil - " + user.Id + ".jpg";
                user.Nombre = txtNombre.Text;
                user.Apellido = txtApellido.Text;


                //user.FechaNacimiento = DateTime.Parse(TxtFechaNacimiento.Text);

                negocio.ActualizarPerfil(user);

                //LEER IMG
                //[4.Subir Imagen a Perfil]-- %> --%>
                Image img = (Image)Master.FindControl("imgAvatar");
                img.ImageUrl = "~/Images/" + user.ImagenPerfil;
            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
            }
        }
    }
}