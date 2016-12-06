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
        private Boolean hasil;
        private Interface.IntCalon clnDao;
        private Entity.EntCalon cln;
        
        public Form3(string userid)
        {
            user = userid;
            cln = new Entity.EntCalon();
            clnDao = Factory.FactLogin.GetInterfaceCalon();
            InitializeComponent();
            AturText(false);
            AturButton(true);
        }
        
        public void AturText(Boolean status)
        {
            txtNama.Enabled = status;
            txtNomor.Enabled = status;
            txtPartai.Enabled = status;
        }

        public void AturButton(Boolean status)
        {
            btnSubmit.Enabled = status;
            btnKeluar.Enabled = status;
            btnDefault.Enabled = status;
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            View.Form4 f4 = new View.Form4(user);
            f4.Show();
            this.Hide();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            keterangan = "INSERT";
            txtNomor.Text = clnDao.nomorBaru();
            txtNama.Text = "";
            txtPartai.Text = "";
            txtNama.Focus();
            AturText(true);
            AturButton(true);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            cln.SetNomor(txtNomor.Text);
            cln.SetNama(txtNama.Text);
            cln.SetPartai(txtPartai.Text);

            if (keterangan == "INSERT")
            {
                hasil = clnDao.submitCalon(cln);
            }
            else
            {
                hasil = clnDao.updateCalon(cln);
            }

            if (hasil == true)
            {
                MessageBox.Show("Data berhasil disimpan");
            }
            else
            {
                MessageBox.Show("Penyimpanan data gagal");
            }

            AturText(false);
            AturButton(true);
        }
        public byte[] ImageToByteArray(Image img)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
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
