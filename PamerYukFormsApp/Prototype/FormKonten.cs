using PamerYukLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PamerYukFormsApp.Prototype
{
    public partial class FormKonten : Form
    {
        private Konten selectedKonten;
        public FormKonten(int konten_id)
        {
            InitializeComponent();
            this.selectedKonten = FormUtama.service.Lihat_Konten(konten_id);
        }

        private void FormKonten_Load(object sender, EventArgs e)
        {
            //Access File from file address and display
            if(this.selectedKonten.Foto != "null")
            {
                if (File.Exists(this.selectedKonten.Foto))
                {
                    Image image = new Bitmap(File.OpenRead(this.selectedKonten.Foto));
                    panelKonten.BackgroundImage = image;
                    panelKonten.BackgroundImageLayout = ImageLayout.Zoom;
                }
            }
            labelLike.Text = this.selectedKonten.Like.ToString();
            listBoxDeskripsi.Items.Clear();
            listBoxDeskripsi.Items.Add(this.selectedKonten.Caption);
            listBoxKomentar.DataSource = selectedKonten.Comment;
            if (!FormUtama.service.Check_Like(this.selectedKonten.Id))
            {
                buttonLike.Text = "Like";
            }
            else
            {
                buttonLike.Text = "Unlike";
            }
        }

        private void buttonKirim_Click(object sender, EventArgs e)
        {
            string comment = textBoxKomen.Text;
            Komen newKomen = new Komen(comment,DateTime.Now,FormUtama.service.Current_user.Username);
            selectedKonten = FormUtama.service.Tambah_Komen(newKomen,this.selectedKonten);
            FormKonten_Load(sender, e);
        }

        private void panelKonten_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonLike_Click(object sender, EventArgs e)
        {
            if (FormUtama.service.Check_Like(this.selectedKonten.Id))
            {
                //Unlike
                buttonLike.Text = "Like";
                this.selectedKonten = FormUtama.service.Delete_Like(this.selectedKonten.Id);
            }
            else
            {
                //Like
                buttonLike.Text = "Unlike";
                this.selectedKonten = FormUtama.service.Tambah_Like(this.selectedKonten.Id);
            }
            FormKonten_Load(sender, e);
        }
    }
}
