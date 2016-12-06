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
        private SqlCommand command;
        private SqlDataReader reader;
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
                query = "INSERT INTO tb_calon VALUES ('"
                    + e.getNomor() + "','"
                    + e.getNama() + "','"
                    + e.getPartai() + "')";
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

        public Boolean updateCalon(Entity.EntCalon e)
        {
            status = false;
            try
            {
                query = "UPDATE tb_calon SET nama_calon = '" +
                        e.getNama() + "', partai_calon = '" +
                        e.getPartai() + "'"+
                        "' WHERE id_staff = '" +
                        e.getNomor() + "' is not null";
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
                command = koneksi.CreateCommand();
                command.CommandText = query;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.IsDBNull(0))
                    {
                        kodeBaru = "01";
                    }
                    else
                    {
                        kode = Int16.Parse(reader.GetString(0).ToString());
                        if (kode < 10)
                        {
                            kodeBaru = "0" + (kode + 1);
                        }
                        else
                        {
                            kodeBaru = "" + (kode + 1);
                        }
                    }
                }

                koneksi.Close();
            }
            catch (SqlException se)
            {
                Console.WriteLine("ERROR" + se);
            }

            return kodeBaru; 
        }

        
    }
}
