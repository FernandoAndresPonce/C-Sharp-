using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using LogicaNegocio;

namespace WebApp
{
    public partial class ListaPokemon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
            NegocioPokemon listaPokemon = new NegocioPokemon();
            dgvPokedex.DataSource = listaPokemon.listaConSP();
            dgvPokedex.DataBind();

        
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormPokemon.aspx", false);
        }

        protected void dgvPokedex_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Id = dgvPokedex.SelectedDataKey.Value.ToString();
            Response.Redirect("FormPokemon.aspx?Id=" + Id, false);
        }

        protected void dgvPokedex_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
          
            dgvPokedex.PageIndex = e.NewPageIndex;
            dgvPokedex.DataBind();
        }
    }
}