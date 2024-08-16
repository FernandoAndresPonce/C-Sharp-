using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace WebApplication1
{
    public partial class AutoForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                drop.Items.Add("Verde");
                drop.Items.Add("Blanco");
                drop.Items.Add("Azul");
            }

            if(Request.QueryString["Id"] != null)
            {
                int id = int.Parse(Request.QueryString["Id"].ToString());
                List<Auto> temporal = (List<Auto>)Session["listaAutos"];
                Auto seleccionado = temporal.Find(x => x.Id == id);

                txtModelo.Text = seleccionado.Modelo;
                txtDescripcion.Text = seleccionado.Descripcion;
                txtId.Text = seleccionado.Id.ToString();
                txtId.ReadOnly = true;
            }

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Auto newAuto = new Auto();

            newAuto.Id = int.Parse(txtId.Text);
            newAuto.Modelo = txtModelo.Text;
            newAuto.Descripcion = txtDescripcion.Text;
            newAuto.Color = drop.SelectedValue;
            // con la fecha y el TextMode = date, usamos de esta manera
            newAuto.Fecha = DateTime.Parse(txtFecha.Text);
            //checkbox lo capturamos de esta manera.
            newAuto.Usado = cbUsado.Checked;
            if (rbImportado.Checked)
                newAuto.Importado = true;
            else if (rbNacional.Checked)
                newAuto.Importado = false;

            //PASO 2 PARA AGREGAR A LA TABLA
            // dos manera de hacerlo.

            //((List<Auto>)Session["listaAutos"]).Add(newAuto);

            // otra

            List<Auto> temporal = (List<Auto>)Session["listaAutos"];
            temporal.Add(newAuto);

            Response.Redirect("Default.aspx");
        }

        protected void rbImportado_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}