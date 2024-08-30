using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Helper
{
    public static class Validacion
    {
        //Validaciones.
        public static bool validaTextoVacio(object control)
        {
            if(control is TextBox)
            {
                if (string.IsNullOrEmpty(((TextBox)control).Text))
                    return false;
                else
                    return true;
            }
            return false;
        }
    }
}
