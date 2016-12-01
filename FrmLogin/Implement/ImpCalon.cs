using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FrmLogin.Implement
{
    class ImpCalon : Interface.IntCalon
    {
        private string query;
        private Boolean status;
        private SqlConnection koneksi;
        public ImpCalon()
        {
            koneksi = KoneksiDB.Koneksi.getKoneksi();
        }

        //Submit Data
        public Boolean submitCalon(String kode, String nama, String partai)
        {
            status = false;
            try
            {
                query = "INSERT INTO tb_calon VALUES ('"
                    + kode + "','"
                    + nama + "','"
                    + partai + "')";
                koneksi.Open();
                SqlCommand command = koneksi.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                status = true;
                koneksi.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("ERROR" + ex.Message);
            }
            return status;
        }

        //Buat Nomor Urut Calon
        public String nomorBaru()
        {
            int kode = 0;
            string kodeBaru = "";
            try
            {
                query = "SELECT MAX(nomor_calon) FROM tb_calon";
                koneksi.Open();
                SqlCommand command = koneksi.CreateCommand();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    kode = Int16.Parse(reader.GetString(0).ToString());
                    if(kode < 10)
                    {
                        kodeBaru = "0" + (kode + 1);
                    }
                    else
                    {
                        kodeBaru = "" + (kode + 1);
                    }
                }
                koneksi.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("ERROR" + ex.Message);
            }
            return kodeBaru;
        }
    }
}
