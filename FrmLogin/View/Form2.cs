using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace FrmLogin
{
    public partial class Form2 : Form
    {
        private string user;
        public Form2(string userid)
        {
            user = userid;
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            var Form5 = new View.Form5();
            Form5.Show(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            View.Form4 f4 = new View.Form4(user);
            f4.Show();
            this.Hide();
        }
    }
}
   

