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
    public partial class Default : System.Web.UI.Page
    {
        //2.[ Listar con ForeachPágina ]
        public List<Pokemon> ListaPokemon { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            NegocioPokemon negocio = new NegocioPokemon();
            ListaPokemon = negocio.listaConSP();

            //[2.Listar con RepeaterPágina]
            //--[6.Listar con RepeaterPágina]
            if (!IsPostBack)
            {
                repRepetidor.DataSource = ListaPokemon;
                repRepetidor.DataBind();
            }
        }

        protected void btnEjemplo_Click(object sender, EventArgs e)
        {
            //<% --[5.Listar con RepeaterPágina], ahora capturamos el Argumento que trae el button %>
            string valor = ((Button)sender).CommandArgument;
        }
    }
}