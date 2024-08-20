using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using AcessoDatos;

namespace NegocioLogica
{
    //2.Login y PermisosPágina
    public class UsuarioNegocio
    {
        private Acceso datos;

        public UsuarioNegocio()
        {
            this.datos = new Acceso();
        }
       public bool Loguear(Usuario usuario)
        {

            try
            {
                datos.setearConsulta("Select Id, TipoUser from Usuarios where Usuario =@Usuario And Password =@Password");
                datos.setearParametros("@Usuario", usuario.User);
                datos.setearParametros("@Password", usuario.Password);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    usuario.Id = (int)datos.Lector["Id"];
                    usuario.TipoUser = (int)datos.Lector["TipoUser"] == 2 ? TipoUsuario.ADMIN : TipoUsuario.NORMAL;
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
