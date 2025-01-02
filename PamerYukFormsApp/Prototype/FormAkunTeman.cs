using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PamerYukLibrary;

namespace PamerYukFormsApp.Prototype
{
    public partial class FormAkunTeman : Form
    {
        User selectedUser;
        public FormAkunTeman(Teman selectedTeman)
        {
            InitializeComponent();
            selectedUser = FormUtama.service.Cari_AkunTeman(selectedTeman.Username);
        }

        private void FormAkunTeman_Load(object sender, EventArgs e)
        {
            textBoxUsername.Text = selectedUser.Username;
            textBoxKota.Text = selectedUser.Kota.Nama;
            textBoxTanggalLahir.Text = selectedUser.TglLahir.Date.ToString("dd-MMMM-yyyy");
            listBoxKisahHidup.DataSource = selectedUser.ListKisahHidup;
        }


        private void buttonKonten_Click(object sender, EventArgs e)
        {
            FormDaftarKonten frm = new FormDaftarKonten(selectedUser);
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void buttonChat_Click(object sender, EventArgs e)
        {
            FormPercakapan form = new FormPercakapan(selectedUser);
            form.Owner = this;
            form.ShowDialog();

        }
    }
}
