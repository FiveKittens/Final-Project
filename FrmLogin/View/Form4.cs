using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin.View
{
    public partial class Form4 : Form
    {
        private string userid;
        private string nama;
        private Interface.IntDashboard dashboard;
        public Form4(string user)
        {
            userid = user;
            dashboard = Factory.FactLogin.GetInterfaceDashboard();
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            nama = dashboard.Nama(userid);

            label2.Text = userid;
            label4.Text = nama;
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(userid);
            f2.Show();
            this.Hide();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(userid);
            f3.Show();
            this.Hide();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            FrmLogin f1 = new FrmLogin();
            f1.Show();
            this.Hide();
        }
    }
}
