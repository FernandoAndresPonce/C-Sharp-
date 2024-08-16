using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace LogicaNegocio
{
    public class NegocioPokemon
    {
        private Acceso datos;

        public NegocioPokemon()
        {
            this.datos = new Acceso();
        }
        public List<Pokemon> listaConSP()
        {
            List<Pokemon> listaPokemones = new List<Pokemon>();

            try
            {
                //(Ya no sirve mas para lo que infiere a lista en app web)
                //datos.setearConsulta("select P.Id, P.Numero, P.Nombre, P.Descripcion, P.UrlImagen, T.Descripcion, D.Descripcion, P.IdTipo, P.IdDebilidad from POKEMONS P, ELEMENTOS T, ELEMENTOS D where P.IdTipo = T.Id  and P.IdDebilidad = D.Id and P.Activo = 1");
                //3. [Listar con Stored ProcedurePágina]
                datos.setearProcedimientoAlmacenado("storedListar");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Pokemon auxPokemon = new Pokemon();

                    auxPokemon.Id = (int)datos.Lector["Id"];
                    auxPokemon.Numero = (int)datos.Lector["Numero"];
                    auxPokemon.Nombre = (string)datos.Lector["Nombre"];
                    if (!(datos.Lector["UrlImagen"] is DBNull))
                        auxPokemon.UrlImagen = (string)datos.Lector["UrlImagen"];
                    auxPokemon.Descripcion = (string)datos.Lector["Descripcion"];

                    auxPokemon.Tipo = new Elemento();
                    auxPokemon.Tipo.Descripcion = (string)datos.Lector["Tipo"];
                    auxPokemon.Debilidad = new Elemento();
                    auxPokemon.Debilidad.Descripcion = (string)datos.Lector["Debilidad"];

                    listaPokemones.Add(auxPokemon);
                }

                return listaPokemones;


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
