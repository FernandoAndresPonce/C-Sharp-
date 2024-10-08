﻿using System;
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
                    //<% --[5v.dropdownlist Enlazado]-- %>
                    auxPokemon.Tipo.Id = (int)datos.Lector["IdTipo"];
                    auxPokemon.Debilidad = new Elemento();
                    auxPokemon.Debilidad.Descripcion = (string)datos.Lector["Debilidad"];
                    auxPokemon.Debilidad.Id = (int)datos.Lector["IdTipo"];

                    auxPokemon.Activo = bool.Parse(datos.Lector["Activo"].ToString());

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

        //2.Modificar Objeto.
        public Pokemon filtroIdPokemon(string Id = "")
        {
            Pokemon auxPokemon = new Pokemon();

            try
            {

                datos.setearConsulta("Select P.Id, P.Numero, P.Nombre, P.Descripcion, P.UrlImagen, P.IdTipo, P.IdDebilidad, T.Descripcion Tipo, D.Descripcion Debilidad, P.Activo from POKEMONS P, ELEMENTOS T, ELEMENTOS D where P.IdTipo = T.Id And P.IdDebilidad = D.Id And P.Id = " + Id);
                datos.ejecutarLectura();


                while (datos.Lector.Read())
                {


                    auxPokemon.Id = (int)datos.Lector["Id"];
                    auxPokemon.Numero = (int)datos.Lector["Numero"];
                    auxPokemon.Nombre = (string)datos.Lector["Nombre"];
                    if (!(datos.Lector["UrlImagen"] is DBNull))
                        auxPokemon.UrlImagen = (string)datos.Lector["UrlImagen"];
                    auxPokemon.Descripcion = (string)datos.Lector["Descripcion"];

                    auxPokemon.Tipo = new Elemento();
                    auxPokemon.Tipo.Descripcion = (string)datos.Lector["Tipo"];
                    //<% --[5v.dropdownlist Enlazado]-- %>
                    auxPokemon.Tipo.Id = (int)datos.Lector["IdTipo"];
                    auxPokemon.Debilidad = new Elemento();
                    auxPokemon.Debilidad.Descripcion = (string)datos.Lector["Debilidad"];
                    auxPokemon.Debilidad.Id = (int)datos.Lector["IdTipo"];

                    auxPokemon.Activo = bool.Parse(datos.Lector["Activo"].ToString());


                }

                return auxPokemon;


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

        //5.Modificar Objeto.
        public void ModificarConSp(Pokemon updatePokemon)
        {
            try
            {
                datos.setearProcedimientoAlmacenado("storedModificar");

                datos.setearParametros("@Numero", updatePokemon.Numero);
                datos.setearParametros("@Nombre", updatePokemon.Nombre);
                datos.setearParametros("@Descripcion", updatePokemon.Descripcion);
                datos.setearParametros("@UrlImagen", updatePokemon.UrlImagen);
                datos.setearParametros("@IdTipo", updatePokemon.Tipo.Id);
                datos.setearParametros("@IdDebilidad", updatePokemon.Debilidad.Id);
                datos.setearParametros("@Id", updatePokemon.Id);

                datos.ejectuarAccion();
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

        public void EliminarConSp(Pokemon idPokemon)
        {
            try
            {
                datos.setearProcedimientoAlmacenado("storedEliminarPokemon");
                datos.setearParametros("@Id", idPokemon.Id);
                datos.ejectuarAccion();

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




        //[1.Crear Pokemon]
        public void AgregarConSp(Pokemon newPokemon)
        {
            try
            {

                datos.setearProcedimientoAlmacenado("storedProcedureAltaPokemon");
                datos.setearParametros("@numero", newPokemon.Numero);
                datos.setearParametros("@nombre", newPokemon.Nombre);
                datos.setearParametros("@descripcion", newPokemon.Descripcion);
                datos.setearParametros("@urlImagen", newPokemon.UrlImagen);
                datos.setearParametros("@idTipo", newPokemon.Tipo.Id);
                datos.setearParametros("@idDebilidad", newPokemon.Debilidad.Id);
                //datos.setearParametros("@idEvolucion", null);

                datos.ejectuarAccion();
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

        //public void ReactivarConSp(int v)
        //{
        //    try
        //    {
        //        datos.setearProcedimientoAlmacenado("");
        //        datos.setearParametros();
        //        datos.ejectuarAccion();

        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //    finally
        //    {
        //        datos.cerrarConexion();
        //    }
        //}

        //[3.Inactivar ]
        //[3.Reactivar Objeto]
        public void InactivarConSp(int v, bool activo = false)
        {
            try
            {


                datos.setearProcedimientoAlmacenado("storedInactivarPokemon");
                datos.setearParametros("@Id", v);
                datos.setearParametros("@Activo", activo);
                datos.ejectuarAccion();


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

        //[9.Filtro Avanzado]--%>
        public List<Pokemon> filtrarAvanzado(string campo, string criterio, string filtro, string estado)
        {
            
            List<Pokemon> listaPokemon = new List<Pokemon>();
            try
            {
                string consulta = "select P.Numero, P.Nombre, P.Descripcion, P.UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id, P.Activo  from POKEMONS P, ELEMENTOS E, ELEMENTOS D where P.IdTipo = E.Id And P.IdDebilidad = D.Id And";
                switch (campo)
                {
                    case "Numero":
                        if (criterio != null)
                        {
                            switch (criterio)
                            {
                                case "Mayor a":
                                    consulta += " Numero > " + filtro;
                                    break;
                                case "Menor a":
                                    consulta += " Numero < " + filtro;
                                    break;
                                case "Igual a":
                                    consulta += " Numero = " + filtro;
                                    break;
                            }
                        }
                        break;
                    case "Nombre":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += " P.Nombre like " + "'" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += " P.Nombre like " + "'%" + filtro + "'";
                                break;
                            case "Contiene":
                                consulta += " P.Nombre like " + "'%" + filtro + "%'";
                                break;
                        }

                        break;

                    case "Tipo":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += " E.Descripcion like " + "'" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += " E.Descripcion like " + "'%" + filtro + "'";
                                break;
                            default:
                                consulta += " E.Descripcion like " + "'%" + filtro + "%'";
                                break;
                        }
                        break;
                    default:
                        break;
                }

                if(estado == "Activo")
                {
                    consulta += " And P.Activo = 1";
                }
                else if(estado == "Inactivo")
                {
                    consulta += " And P.Activo = 0";
                }


                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Pokemon auxPokemon = new Pokemon();
                    auxPokemon.Id = (int)datos.Lector["Id"];
                    auxPokemon.Numero = (int)datos.Lector["Numero"];
                    auxPokemon.Nombre = (string)datos.Lector["Nombre"];
                    auxPokemon.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["UrlImagen"] is DBNull))
                        auxPokemon.UrlImagen = (string)datos.Lector["UrlImagen"];
                    auxPokemon.Tipo = new Elemento();
                    auxPokemon.Tipo.Id = (int)datos.Lector["IdTipo"];
                    auxPokemon.Tipo.Descripcion = (string)datos.Lector["Tipo"];
                    auxPokemon.Debilidad = new Elemento();
                    auxPokemon.Debilidad.Id = (int)datos.Lector["IdDebilidad"];
                    auxPokemon.Debilidad.Descripcion = (string)datos.Lector["Debilidad"];

                    auxPokemon.Activo = bool.Parse(datos.Lector["Activo"].ToString());

                    listaPokemon.Add(auxPokemon);

                }

                return listaPokemon;
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
