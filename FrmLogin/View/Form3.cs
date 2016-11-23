using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FrmLogin.View
{
    public partial class Form3 : Form
    {
        private string keterangan;
        private Entity.EntCalon calon;
        private Interface.IntCalon cln;
        private int i;

        public void aktifTeks(Boolean status)
        {
            txtNomor.Enabled = status;
            txtNama.Enabled = status;
            txtPartai.Enabled = status;
        }

        public Form3()
        {
            cln = Factory.FactLogin.GetInterfacesubmitCalon();
            calon = new Entity.EntCalon();
            InitializeComponent();
        }

        public void aktifButton(Boolean status)
        {
            btnSubmit.Enabled = status;
            btnKeluar.Enabled = status;
            btnDefault.Enabled = status;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            aktifButton(false);
            aktifTeks(true);

            keterangan = "INSERT";
            txtNomor.Text = cln.nomorBaru().ToString();
            txtNama.Text = "";
            txtPartai.Text = "";
        }
        private void btnDefault_Click(object sender, EventArgs e)
        {
            aktifButton(false);
            aktifTeks(true);

            txtNama.Clear();
            txtNomor.Clear();
            txtNomor.Clear();
            txtNomor.Focus();
        }
        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            /*MessageBox.Show("Login Sukses");*/
            this.Hide();
        }
    }
}
