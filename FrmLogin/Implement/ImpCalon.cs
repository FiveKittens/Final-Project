using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FrmLogin.Implement
{
    class ImpCalon : Interface.IntCalon
    {
        private string query;
        private Boolean status;
        private SqlConnection koneksi;
        private SqlCommand command;

        public ImpCalon()
        {
            koneksi = KoneksiDB.Koneksi.getKoneksi();
        }

        //Submit Data
        public Boolean submitCalon(Entity.EntCalon e)
        {
            status = false;
            try
            {
                query = "INSERT INTO tb_pekerjaan VALUES ('"
                    + e.getNomor() + "','"
                    + e.getNama() + "','"
                    + e.getPartai() + "')";
                koneksi.Open();
                command = new SqlCommand();
                command.Connection = koneksi;
                command.CommandText = query;
                command.ExecuteNonQuery();
                status = true;
                koneksi.Close();
            }
            catch (SqlException)
            {
                Console.WriteLine("ERROR");
            }
            return status;
        }

        //Buat Nomor Urut Calon
        public int nomorBaru()
        {
            int kode = 1;
            try
            {
                query = "SELECT MAX(nomr_calon) FROM tb_calon";
                koneksi.Open();
                command = new SqlCommand();
                command.Connection = koneksi;
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    kode = reader.GetInt32(0) + 1;
                }
                koneksi.Close();
            }
            catch (SqlException)
            {
                Console.WriteLine("ERROR");
            }
            return kode;
        }
    }
}
