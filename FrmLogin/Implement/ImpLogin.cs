using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FrmLogin.Implement
{
    class ImpLogin : Interface.IntLogin
    {
        private string query;
        private Boolean status;
        private SqlConnection koneksi;

        public ImpLogin()
        {
            koneksi = KoneksiDB.Koneksi.getKoneksi();
        }

        public Boolean Login(String kode, String password)
        {

            query = "SELECT id_staff, password FROM tb_admin " +
                    "WHERE id_staff = '" + kode + "' AND password = '" + password + "'";

            koneksi.Open();

            SqlCommand command = koneksi.CreateCommand();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if ((reader.GetString(0).ToString() == kode)
                    && (reader.GetString(1).ToString() == password))
                {
                    status = true;
                }
                else
                {
                    status = false;
                }
            }

            koneksi.Close();

            return status;
        }
    }
}
