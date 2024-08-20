using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    // este tipousuario es como una clase mas, y podria ponerla en otro fichero
    public enum TipoUsuario
    {
        NORMAL = 1,
        ADMIN = 2
    }
    public class Usuario
    {
        //1.Login y PermisosPágina
        
        public int Id { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public TipoUsuario TipoUser { get; set; }

        public Usuario (string user, string password, bool admin)
        {
            User = user;
            Password = password;

            TipoUser = admin ? TipoUsuario.ADMIN : TipoUsuario.NORMAL;
        }
    }
}
