using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Helper
{

    //<% --[5.Login]-- %> IMPORTANTISIMOOOOOO ESTA CLASEEEEE!!!! STATICCC
    public static class Seguridad
    {
        //aca al poner object como parametro, no debo pasar la session a un tipo objecto, porque ya lo tomaria.
        public static bool sessionActiva(object user)
        {
            Usuario usuario = user != null ? (Usuario)user : null;
            if (usuario != null && usuario.Id != 0)
            {
                return true;
            }
            return false;
        }

        //<% --[8.Login]

        public static bool esAdmin(object user)
        {
            Usuario usuario = user != null ? (Usuario)user : null;
            return usuario != null ? usuario.Admin : false;
        }
    }
}
