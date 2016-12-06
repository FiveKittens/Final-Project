using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FrmLogin.KoneksiDB
{
    class Koneksi
    {
        private static SqlConnection koneksi;
        public static SqlConnection getKoneksi()
        {
            koneksi = new SqlConnection();
            koneksi.ConnectionString = "Data Source=XENOM_PC;Initial Catalog=db_pemilu123;Integrated Security=True"; 
            return koneksi;
        }
    }
}
