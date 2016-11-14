using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmLogin.Factory
{
    class FactLogin
    {
        private static Interface.IntLogin Login;

        public static Interface.IntLogin GetInterfaceLogin()
        {
            Login = new Implement.ImpLogin();
            return Login;
        }
    }
}
