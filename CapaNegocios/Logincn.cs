using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocios
{
    public  class Logincn
    {
        private logincd Login = new logincd();
        //seguridad del login
        public bool securidadlogin()
        {
            if (UserLogin_.iduser >= 1)
            {
                if (Login.existsUser(UserLogin_.iduser, UserLogin_.possition) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool LoginUSER(string user, string pass)
        {
            return Login.Login(user, pass);
        }

       
    }
}
