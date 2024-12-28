using AxWMPLib;
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
    public partial class FormTambahKonten : Form
    {
        OpenFileDialog fileDialog;

        public FormTambahKonten()
        {
            InitializeComponent();
        }

        private void buttonGantiGambar_Click(object sender, EventArgs e)
        {
            pictureBoxMedia.Visible = false;
            //videoPlayer.Visible = false;
            //videoPlayer.Ctlcontrols.stop();
            fileDialog = new OpenFileDialog();
            if(fileDialog.ShowDialog() == DialogResult.OK )
            {
                if (Path.GetExtension(fileDialog.FileName) == ".jpg")
                {
                    Image selectedImage = new Bitmap(fileDialog.FileName);
                    pictureBoxMedia.Image = selectedImage;
                    pictureBoxMedia.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBoxMedia.Visible = true;
                    
                }
                else
                {

                    try
                    {
                        //videoPlayer.URL = fileDialog.FileName;   
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error playing video: " + ex.Message);
                    }

                }
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormUtama.service.Tambah_Konten(textBoxCaption.Text, fileDialog);
        }

        private void FormTambahKonten_Load(object sender, EventArgs e)
        {
            pictureBoxMedia.Visible = false;
        }


        private void buttonTambahTag_Click(object sender, EventArgs e)
        {
            FormDaftarTeman form = new FormDaftarTeman(true);
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
