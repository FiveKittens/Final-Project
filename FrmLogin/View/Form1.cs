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
        private Entity.EntLogin login;
        private Implement.ImpLogin impLogin;
        public FrmLogin()
        {
            impLogin = new Implement.ImpLogin();
            login = new Entity.EntLogin();
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
                login.setKode(txtUser.Text);
                login.setPassword(txtPassword.Text);

                status = impLogin.Login(login);

                if (status == false)
                {
                    MessageBox.Show("Maaf login gagal");
                    txtUser.Text = "";
                    txtPassword.Text = "";
                    txtUser.Focus();
                }
                else
                {
                    /*Form1 f = new Form1();
                    f.Show();*/
                    MessageBox.Show("Login Sukses");
                    this.Hide();
                }
            }
        }
    }  
}
