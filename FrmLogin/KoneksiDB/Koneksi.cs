using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace FrmLogin.KoneksiDB
{
    class Koneksi
    {
        public static MySqlConnection getKoneksi()
        {
            string strCon = "SERVER = localhost; PORT = 3306; " +
                        "UID = root; PWD = ; " +
                        "DATABASE = db_psb9279;";
            return new MySqlConnection(strCon);
        }
    }
}
