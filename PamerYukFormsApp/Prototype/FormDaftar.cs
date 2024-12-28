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

namespace PamerYukFormsApp.Prototype
{
    public partial class FormDaftar : Form
    {
        FileDialog fileDialog;
        public FormDaftar()
        {
            InitializeComponent();
        }

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string confirm_password = textBoxKonfirmasi.Text;
            Kota selected_kota = (Kota)comboBoxKota.SelectedItem;
            DateTime tanggalLahir = dateTimePicker1.Value.Date;
            string profile_picture= @"C:\PamerYuk\default_image.jpg";//nanti set default image di Folder yang dicreate
            if (fileDialog.FileName != null)
            {
                profile_picture = fileDialog.FileName;
            }
            string noKTP = textBoxNoKTP.Text;                                    

            if (CheckPassword(password,confirm_password))
            {
                FormUtama.service.Daftar(username, password, tanggalLahir, noKTP, profile_picture, selected_kota);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please make sure password and confirmation password have the same value");
            }
        }

        private void FormDaftar_Load(object sender, EventArgs e)
        {
            comboBoxKota.DataSource = FormUtama.service.ListKota;
            comboBoxKota.DisplayMember = "Nama";
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region METHOD
        private bool CheckPassword(string pass, string confirm_pass)
        {
            return pass == confirm_pass;
        }
        #endregion
    }
}
