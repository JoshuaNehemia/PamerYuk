using PamerYukLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PamerYukFormsApp.Prototype2.User_Control
{
    public partial class UC_DaftarDataDiri : UserControl
    {
        MainForm mainForm;
        FileDialog fileDialog;
        public string username = "";
        public string password = "";
        public string confirm_password = "";
        
        
        public UC_DaftarDataDiri(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void buttonMasuk_Click(object sender, EventArgs e)
        {
            UC_Login uc_login = new UC_Login(mainForm);
            mainForm.panelUtama.Controls.Remove(this);
            mainForm.panelUtama.Controls.Add(uc_login);
        }

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            string noKTP = textBoxNoKtp.Text;
            Kota selected_kota = (Kota)comboBoxKota.SelectedItem;
            DateTime tanggalLahir = dateTimePickerTglLahir.Value.Date;
            string profile_picture = @"C:\PamerYuk\default_image.jpg";//nanti set default image di Folder yang dicreate
            if (fileDialog.FileName != null)
            {
                profile_picture = fileDialog.FileName;
            }
            MainForm.service.Daftar(username, password, tanggalLahir, noKTP, profile_picture, selected_kota);

            MessageBox.Show("Berhasil membuat akun");

            this.pictureBox2.Image = Properties.Resources.Checked_true;
            //Proses login selesai, User Control close, Clear object yg show di panelUtama
            mainForm.panelUtama.Controls.Remove(this);

            //Change to uc_login before goes to HomePage
            UC_Login uc_login = new UC_Login(mainForm);
            mainForm.panelUtama.Controls.Add(uc_login);
            mainForm.panel1.Hide();


            /*mainForm.panelUtama.Show();*/
            mainForm.FormBorderStyle = FormBorderStyle.Sizable;
            mainForm.MaximizeBox = true;
            mainForm.MinimizeBox = true;            

            
        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            try
            {
                fileDialog = new OpenFileDialog();
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(fileDialog.FileName) == ".jpg")
                    {
                        Image selectedImage = new Bitmap(fileDialog.FileName);
                        panelFoto.BackgroundImage = selectedImage;
                        panelFoto.BackgroundImageLayout = ImageLayout.Zoom;
                        panelFoto.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Only support jpg.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UC_DaftarDataDiri_Load(object sender, EventArgs e)
        {
            comboBoxKota.DataSource = FormUtama.service.ListKota;
            comboBoxKota.DisplayMember = "Nama";
        }
    }
}
