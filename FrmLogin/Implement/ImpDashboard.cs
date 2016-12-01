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
        private string nama;
        private SqlConnection koneksi;

        public ImpDashboard()
        {
            koneksi = KoneksiDB.Koneksi.getKoneksi();
        }

        public String Nama(String user)
        {
            
            try
            {
                query = "SELECT nama_staff FROM tb_admin " +
                        "WHERE id_staff = '" + user + "'";

                koneksi.Open();

                SqlCommand command = koneksi.CreateCommand();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                   nama = reader.GetString(0).ToString();
                }
                koneksi.Close();
            }catch (SqlException se)
            {
                Console.WriteLine("ERROR" + se);
            }
            return nama;
        }
    }
}
