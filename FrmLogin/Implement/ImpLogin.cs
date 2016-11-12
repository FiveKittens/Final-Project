using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FrmLogin.Implement
{
    class ImpLogin : Interface.IntLogin
    {
        private string query;
        private Boolean status;
        private MySqlConnection koneksi;

        public ImpLogin()
        {
            koneksi = KoneksiDB.Koneksi.getKoneksi();
        }

        public Boolean Login(Entity.EntLogin e)
        {

            query = "SELECT id_staff, password FROM tb_staff " +
                    "WHERE id_staff = '" + e.getKode() + "' AND password = '" + e.getPassword() + "'";

            koneksi.Open();

            MySqlCommand command = koneksi.CreateCommand();
            command.CommandText = query;
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if ((reader.GetString(0).ToString() == e.getKode())
                    && (reader.GetString(1).ToString() == e.getPassword()))
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
