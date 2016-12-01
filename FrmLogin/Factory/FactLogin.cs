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
        private static Interface.IntCalon Calon;
        private static Interface.IntDashboard Dashboard;

        public static Interface.IntLogin GetInterfaceLogin()
        {
            Login = new Implement.ImpLogin();
            return Login;
        }

        public static Interface.IntCalon GetInterfaceCalon()
        {
            Calon = new Implement.ImpCalon();
            return Calon;
        }

        public static Interface.IntDashboard GetInterfaceDashboard()
        {
            Dashboard = new Implement.ImpDashboard();
            return Dashboard;
        }
        
        
    }
}
