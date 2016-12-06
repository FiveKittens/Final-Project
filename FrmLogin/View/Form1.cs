using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin
{
    public partial class FrmLogin : Form
    {
        private Boolean status;
        private Interface.IntLogin Login;
        public FrmLogin()
        {
            Login = Factory.FactLogin.GetInterfaceLogin();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Kode dan Password harus diisi !");
            }
            else
            {
                status = Login.Login(txtUser.Text, txtPassword.Text);

                if (status == false)
                {
                    MessageBox.Show("Maaf login gagal");
                    txtUser.Text = "";
                    txtPassword.Text = "";
                    txtUser.Focus();
                }
                else
                {
                    Form2 f2 = new Form2(txtUser.Text);
                    View.Form3 f3 = new View.Form3(txtUser.Text);
                    View.Form4 f4 = new View.Form4(txtUser.Text);
                    f4.Show();
                    this.Hide();
                }
            }
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }  
}
