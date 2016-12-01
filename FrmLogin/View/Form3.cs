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
using System.IO;

namespace FrmLogin.View
{
    public partial class Form3 : Form
    {
        private string keterangan;
        private string user;
        private string lastDir;
        private Boolean status;
        private Interface.IntCalon cln;

        public void aktifTeks(Boolean status)
        {
            txtNomor.Enabled = status;
            txtNama.Enabled = status;
            txtPartai.Enabled = status;
        }

        public Form3(string userid)
        {
            user = userid;
            cln = Factory.FactLogin.GetInterfaceCalon();
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            aktifTeks(false);
            aktifButton(true);
            txtNomor.Focus();
            txtNomor.Text = cln.nomorBaru();
            txtNama.Focus();
        }

        public void aktifButton(Boolean status)
        {
            btnSubmit.Enabled = status;
            btnKeluar.Enabled = status;
            btnDefault.Enabled = status;
        }

        private void btnKeluar_Click_1(object sender, EventArgs e)
        {
            View.Form4 f4 = new View.Form4(user);
            f4.Show();
            this.Hide();
        }
        public byte[] ImageToByteArray(Image img)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            aktifButton(false);
            aktifTeks(true);
            
            if (txtNomor.Text == "" || txtNama.Text == "" || txtPartai.Text == "")
            {
                MessageBox.Show("Semua Kolom Harus Diisi !");
                txtNomor.Text = "";
                txtNama.Text = "";
                txtPartai.Text = "";
                txtNama.Focus();
            }
            else
            {
                status = cln.submitCalon(txtNomor.Text, txtNama.Text, txtPartai.Text);

                if (status == false)
                {
                    MessageBox.Show("Maaf login gagal");
                    keterangan = "INSERT";
                    txtNomor.Text = cln.nomorBaru().ToString();
                    txtNama.Text = "";
                    txtPartai.Text = "";
                    txtNama.Focus();
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Please elect file.. ";
            open.Filter = "Image Files(*.png; *.jpg; *.bmp)|*.png; *.jpg; *.bmp";
            if (lastDir == null)
            {
                open.InitialDirectory = @"C:\";
            }
            else
            {
                open.InitialDirectory = lastDir;
            }

            string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\SrcImg\";

            if (Directory.Exists(appPath) == false)
            {
                Directory.CreateDirectory(appPath);
            }

            if (open.ShowDialog() == DialogResult.OK)
            {
                /*fileName = System.IO.Path.GetFullPath(open.FileName);
                lastDir = open.FileName;
                pictureBox2.Image = new Bitmap(open.FileName);
                    this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;*/
                try
                {
                    string iName = open.SafeFileName;
                    string filepath = open.FileName;
                    File.Copy(filepath, appPath + iName);
                    pictureBox2.Image = new Bitmap(open.FileName);
                    this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                } catch (Exception ex)
                {
                    MessageBox.Show("Unable to open file" + ex.Message);
                }
            }
        }
        
    }
}
