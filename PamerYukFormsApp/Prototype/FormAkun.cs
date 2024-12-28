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

namespace PamerYukFormsApp.Prototype
{
    public partial class FormAkun : Form
    {
        public FormAkun()
        {
            InitializeComponent();
        }

        private void FormAkun_Load(object sender, EventArgs e)
        {
            //Notes : Kota nanti diganti combobox!
            textBoxUsername.Text = FormUtama.service.Current_user.Username;
            textBoxNoKTP.Text = FormUtama.service.Current_user.NoKTP;
            textBoxTanggalLahir.Text = FormUtama.service.Current_user.TglLahir.ToString();
            textBoxKota.Text = FormUtama.service.Current_user.Kota.Nama;
            Image profilePicture = new Bitmap(FormUtama.service.Current_user.Foto);
            panelFotoProfil.BackgroundImage = profilePicture;
            panelFotoProfil.BackgroundImageLayout = ImageLayout.Zoom;
            listBoxKisahHidup.DataSource = DisplayKisahHidup();
        }

        #region METHOD
        private List<string> DisplayKisahHidup()
        {
            List<string> list = new List<string>();
            foreach (KisahHidup kisah in FormUtama.service.Current_user.ListKisahHidup)
            {
                {
                    list.Add(kisah.ToString());
                }
            }
            return list;
        }
        #endregion

        private void buttonEditProfil_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string noKTP = textBoxNoKTP.Text;
            DateTime tgLahir = DateTime.Parse(textBoxTanggalLahir.Text);
            string Image = "";
            Kota kota = null; //Ganti combobox dulu baru bisa di code
            MessageBox.Show("Apakah anda yakin ingin mengubah data akun anda?","Peringatan Perubahan!",MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
               //Update data user
            }
            
        }
    }
}
