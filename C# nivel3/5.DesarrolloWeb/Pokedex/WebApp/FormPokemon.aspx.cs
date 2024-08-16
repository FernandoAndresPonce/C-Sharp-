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
    public partial class FormPokemon : System.Web.UI.Page
    {
        //private Pokemon auxPokemon = null;
        protected void Page_Load(object sender, EventArgs e)
        {

            //[1.Crear Pokemon]
            //no podemos agregar un id, es automatico.
            txtId.Enabled = false;


           

            try
            {

                if (!(IsPostBack))
                {
                    //<% --[3.DropDownList hacia DB]-- %>
                    NegocioElemento negocioElemento = new NegocioElemento();
                    List<Elemento> listaE = negocioElemento.listaElementoSp();

                    ddlTipo.DataSource = listaE;
                    ddlTipo.DataValueField = "Id";
                    ddlTipo.DataTextField = "Descripcion";
                    ddlTipo.DataBind();
                    ddlTipo.Items.Insert(0, new ListItem("Seleccionar ", "0")); // no funca esto por ahora.

                   ddlDebilidad.DataSource = listaE;
                   ddlDebilidad.DataValueField = "Id";
                   ddlDebilidad.DataTextField = "Descripcion";
                   ddlDebilidad.DataBind();


                }


                //1.Modificar Objeto.
                string id = Request.QueryString["Id"] != null ? Request.QueryString["Id"].ToString() : string.Empty;

                //6.Modificar Objeto, debemos poner si isPOsboack porque  se vuelve a recargar el formulario,entonces las modificaciones no se ven reflejadas.
                if (id != string.Empty && !IsPostBack) 
                {

                    NegocioPokemon negocio = new NegocioPokemon();
                    Pokemon pokemonSeleccionado = negocio.filtroIdPokemon(id);

                    //3.Modificar Objeto.
                    txtId.Text = pokemonSeleccionado.Id.ToString();
                    txtNumero.Text = pokemonSeleccionado.Numero.ToString();
                    txtNombre.Text = pokemonSeleccionado.Nombre;
                    txtDescripcion.Text = pokemonSeleccionado.Descripcion;
                    txtUrlImagen.Text = pokemonSeleccionado.UrlImagen;
                    ddlTipo.SelectedValue = pokemonSeleccionado.Tipo.Id.ToString();
                    ddlDebilidad.SelectedValue = pokemonSeleccionado.Debilidad.Id.ToString();

                    //4.Modificar Objeto, para que se carge la imagen, forzamos el evento.
                    //txtUrlImagen_TextChanged(sender, e); o de esta manera.
                    cargarImagen();
                }
            }
            catch (Exception ex)
            {

                Session.Add ("error" ,ex);
                throw;
            }




        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListaPokemon.aspx", false);
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            //[2.Crear Pokemon]
            try
            {
                Pokemon newPokemon = new Pokemon();
                NegocioPokemon negocio = new NegocioPokemon();

                newPokemon.Nombre = txtNombre.Text;
                newPokemon.Numero = int.Parse(txtNumero.Text);
                newPokemon.Tipo = new Elemento();
                newPokemon.Tipo.Id = int.Parse(ddlTipo.SelectedValue);
                newPokemon.Debilidad = new Elemento();
                newPokemon.Debilidad.Id = int.Parse(ddlDebilidad.SelectedValue);
                newPokemon.Descripcion = txtDescripcion.Text;
                newPokemon.UrlImagen = txtUrlImagen.Text;
                


                //4.Modificar Objeto.
                if (Request.QueryString["Id"] != null)
                {
                    //7.Modificar Objeto.
                    newPokemon.Id = int.Parse(txtId.Text);
                    negocio.ModificarConSp(newPokemon);
                }
                else
                {
                    negocio.AgregarConSp(newPokemon);

                }
                
                Response.Redirect("ListaPokemon.aspx", false);
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
            }
        }

        protected void txtUrlImagen_TextChanged(object sender, EventArgs e)
        {
            cargarImagen();
        }

        private void cargarImagen()
        {
            imgUrlImagen.ImageUrl = txtUrlImagen.Text;
        }
    }
}