using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace LogicaNegocio
{
    public class NegocioElemento
    {
        //<%--[2.DropDownList hacia DB]--%>
        private Acceso datos;

        public NegocioElemento()
        {
            this.datos = new Acceso();
        }

        public List<Elemento> listaElementoSp()
        {
            List<Elemento> listaElementos = new List<Elemento>();


            try
            {
            datos.setearProcedimientoAlmacenado("storedListarElementos");
            datos.ejecutarLectura();

            while(datos.Lector.Read())
            {
                Elemento auxElemento = new Elemento();

                auxElemento.Id = (int)datos.Lector["Id"];
                auxElemento.Descripcion = (string)datos.Lector["Descripcion"];

                listaElementos.Add(auxElemento);
            }

            return listaElementos;

            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                datos.cerrarConexion();
            }

        }
    }
}
