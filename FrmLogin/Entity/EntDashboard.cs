using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmLogin.Entity
{
    class EntDashboard
    {
        private string user;
        private string nama;

        public void setUser(string user)
        {
            this.user = user;
        }
        public void setNama(string nama)
        {
            this.nama = nama;
        }
        public string getUser()
        {
            return user;
        }
        public string getNama()
        {
            return nama;
        }
    }
}
