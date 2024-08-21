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
        //[3.Filtro Avanzado]--%>
        public bool FiltroAvanzado { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            //[4.Filtro Avanzado]--%>
            FiltroAvanzado = cbFiltroAvanzado.Checked;

            if (!IsPostBack)
            {
                NegocioPokemon listaPokemon = new NegocioPokemon();
                //[1.Filtro Rapido]
                Session.Add("listaPokemones", listaPokemon.listaConSP());
                dgvPokedex.DataSource = Session["listaPokemones"];
                dgvPokedex.DataBind();
            }

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

        protected void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            //[2.Filtro Rapido]
            List<Pokemon> lista = (List<Pokemon>)Session["listaPokemones"];
            List<Pokemon> listaFiltrada = lista.FindAll(x => x.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper()) || x.Tipo.Descripcion.ToUpper().Contains(txtFiltro.Text.ToUpper()));

            dgvPokedex.DataSource = listaFiltrada;
            dgvPokedex.DataBind();


        }

        //[5.Filtro Avanzado]--%>

        protected void cbFiltroAvanzado_CheckedChanged(object sender, EventArgs e)
        {
            FiltroAvanzado = cbFiltroAvanzado.Checked;
            txtFiltro.Enabled = !FiltroAvanzado;
        }

        protected void ddlCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //[7.Filtro Avanzado]--%>

            ddlCriterio.Items.Clear();
            //var a ser to string porque le agregue texto
            if (ddlCampo.SelectedItem.ToString() == "Numero")
            {
                ddlCriterio.Items.Add("Igual a");
                ddlCriterio.Items.Add("Mayor a");
                ddlCriterio.Items.Add("Menor a");
            }
            else
            {
                ddlCriterio.Items.Add("Contiene");
                ddlCriterio.Items.Add("Comienza con");
                ddlCriterio.Items.Add("Termina con");
            }

        }

         //[8.Filtro Avanzado]--%>
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                NegocioPokemon negocio = new NegocioPokemon();

                dgvPokedex.DataSource =  negocio.filtrarAvanzado(
                    ddlCampo.SelectedItem.ToString(), 
                    ddlCriterio.SelectedItem.ToString(), 
                    txtFiltroAvanzado.Text, 
                    ddlEstado.SelectedItem.ToString());

                dgvPokedex.DataBind();

            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
            }
        }
    }
}