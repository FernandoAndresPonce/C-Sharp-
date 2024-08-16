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
            // PASO 1 PARA SUBIRLO A LA TABLA.
            if (Session["listaAutos"] == null)
            {
                AutoNegocio negocio = new AutoNegocio();
                Session.Add("listaAutos", negocio.listar());
            }

            dgvAutos.DataSource = Session["listaAutos"];
            // aca a diferencia de app de escritorio necesitamos agregar ese metodo.
            dgvAutos.DataBind(); // esto arma la lista ( rederee).
        }

        protected void dgvAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // PASO 2 DE SELECCIONAR UNA FILA, Y OBTENER LOS VALORES
            //var algo = dgvAutos.SelectedRow.Cells[0].Text;
            var id = dgvAutos.SelectedDataKey.Value.ToString();
            Response.Redirect("AutoForm.aspx?Id=" + id);

        }
    }
}