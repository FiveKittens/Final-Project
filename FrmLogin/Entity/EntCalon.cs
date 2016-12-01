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
        private string pict;

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
        public void SetPict(string pict)
        {
            this.pict = pict;
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
        public string getPict()
        {
            return pict;
        }
    }
}
