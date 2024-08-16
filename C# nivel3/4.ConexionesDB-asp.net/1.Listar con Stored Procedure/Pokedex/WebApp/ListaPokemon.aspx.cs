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

            //Procedimiento almacenado, como hacer.

            // 1 paso generarar en la base de datos, tocar la base de dato >> Programmability >> Stored Procedures
            // y ahi deberia estar nuevo Procedimiento almacenado, y lo creamos, en el Query
            // >> create procedure storedListar as << y la consulta la pegamos abajo de eso, luego Execute, y 
            //refrescamos el Stored Procedures, y para ver si esta.
            //exec storedListar, es el nombre que le puse al archivo.
            // y agregamos en la Capa Acceso a DAtos, un setearProcedimientoAlmacenado
        }
    }
}