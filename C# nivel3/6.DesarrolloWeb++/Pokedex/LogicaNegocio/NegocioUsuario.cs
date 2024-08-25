using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;


//<% -- [2.Registro Trainee - output SQL - MailTrap]-- %>

//En DB HACEMOS esto select * from Users


//create procedure storedInsertarNuevo

//@Email varchar(50),
//@Password varchar(50)
//as
//insert into Users(email, password, admin) output inserted.id  values (@Email, @Password, 0)

//exec storedInsertarNuevo 'pedro@gmail.com','pepe1234'

//utput inserted.id  values >> esa parte es nueva para obtener el id  //

namespace LogicaNegocio
{
    public class NegocioUsuario
    {
        private Acceso datos;

        public NegocioUsuario()
        {
            this.datos = new Acceso();
        }
        public int InsertarNuevo(Usuario newUsuario)
        {

            try
            {
                datos.setearProcedimientoAlmacenado("storedInsertarNuevo");
                datos.setearParametros("@Email", newUsuario.Email);
                datos.setearParametros("@Password", newUsuario.Password);

                //<% -- [4.Registro Trainee - output SQL - MailTrap]-- %>
                return datos.ejectuarAccionScalar();


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

        //<% --[3.Subir Imagen a Perfil]-- %>
        public void ActualizarPerfil(Usuario actualizarUsuario)
        {
            try
            {
                datos.setearProcedimientoAlmacenado("storedActualizarImagenPrincipal");
                datos.setearParametros("@imagenPerfil", actualizarUsuario.ImagenPerfil);
                datos.setearParametros("@id", actualizarUsuario.Id);
                datos.setearParametros("@nombre", actualizarUsuario.Nombre);
                datos.setearParametros("@apellido", actualizarUsuario.Apellido);

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

        //<%--[3.Login]--%>
        public bool Login(Usuario usuario)
        {
            try
            {
                datos.setearProcedimientoAlmacenado("storedConfirmarLogin");
                datos.setearParametros("@email", usuario.Email);
                datos.setearParametros("@password", usuario.Password);
                datos.ejecutarLectura();
                if (datos.Lector.Read())
                {
                    usuario.Id = (int)datos.Lector["id"];
                    usuario.Admin = (bool)datos.Lector["admin"];
                    if (!(datos.Lector["imagenPrincipal"] is DBNull))
                    {
                        usuario.ImagenPerfil = (string)datos.Lector["imagenPrincipal"];
                    }

                    if (!(datos.Lector["email"] is DBNull))
                        usuario.Email = (string)datos.Lector["email"];
                    if (!(datos.Lector["nombre"] is DBNull))
                        usuario.Nombre = (string)datos.Lector["nombre"];
                    if (!(datos.Lector["apellido"] is DBNull))
                        usuario.Apellido = (string)datos.Lector["apellido"];




                    return true;
                }

                return false;

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
