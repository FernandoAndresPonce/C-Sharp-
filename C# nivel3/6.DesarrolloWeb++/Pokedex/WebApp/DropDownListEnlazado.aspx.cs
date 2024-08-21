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
    public partial class DropDownListEnlazado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //<% --[3.dropdownlist Enlazado]-- %>

            NegocioPokemon negocioP = new NegocioPokemon();
            NegocioElemento negocioE = new NegocioElemento();
            try
            {
                if (!(IsPostBack))
                {
                    List<Pokemon> listaPokemones = negocioP.listaConSP();
                    Session["listaPokemones"] = listaPokemones;



                    List<Elemento> listaElementos = negocioE.listaElementoSp();
                    ddlTipo.DataSource = listaElementos;
                    ddlTipo.DataTextField = "Descripcion";
                    ddlTipo.DataValueField = "Id";
                    ddlTipo.DataBind();
                    // IMPORTANTE PARA QUE NO APAREZCA UN OBEJTO PRE SELECCIONADO.
                    ddlTipo.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
                }

            }
            catch (Exception ex)
            {

                Session.Add("error", ex);
            }

        }

        protected void ddlTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //<% --[4.dropdownlist Enlazado]-- %>

            int id = int.Parse(ddlTipo.SelectedItem.Value);
            ddlPokemonEnlazadoTipo.DataSource = ((List<Pokemon>)Session["listaPokemones"]).FindAll(x => x.Tipo.Id == id);
            ddlPokemonEnlazadoTipo.DataBind();
        }
    }
}