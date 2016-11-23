using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrmLogin.Entity
{
    class EntCalon
    {
        private int nomor;
        private string nama;
        private string partai;

        public void SetNomor(int nomor)
        {
            this.nomor = nomor;
        }
        public void SetNama(string nama)
        {
            this.nama = nama;
        }
        public void SetPartai(string partai)
        {
            this.partai = partai;
        }
        public int getNomor()
        {
            return nomor;
        }
        public string getNama()
        {
            return nama;
        }
        public string getPartai()
        {
            return partai;
        }
    }
}
