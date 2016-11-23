using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FrmLogin.Implement
{
    class ImpDashboard : Interface.IntDashboard
    {
        private string query;
        private Boolean status;
        private SqlConnection koneksi;
        private SqlCommand command;

        public ImpDashboard()
        {
            koneksi = KoneksiDB.Koneksi.getKoneksi();
        }

        public Boolean Dashboard(String user)
        {
            query = "SELECT id_staff" +
                    "WHERE id_staff = '" + user +"'";
        }
        public Boolean Dashboard(String nama)
        {
            query = "SELECT id_staff" +
                    "WHERE id_staff = '" + nama + "'";
        }
    }
}
