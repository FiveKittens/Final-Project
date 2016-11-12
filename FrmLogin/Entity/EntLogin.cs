using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmLogin.Entity
{
    class EntLogin
    {
        private string kode;
        private string password;

        public void setKode(string kode)
        {
            this.kode = kode;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public string getKode()
        {
            return kode;
        }

        public string getPassword()
        {
            return password;
        }
    }
}
