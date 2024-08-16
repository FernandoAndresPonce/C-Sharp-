using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AutoNegocio negocio = new AutoNegocio();

            dgvAutos.DataSource = negocio.listar();
            // aca a diferencia de app de escritorio necesitamos agregar ese metodo.
            dgvAutos.DataBind(); // esto arma la lista ( rederee).
        }
    }
}