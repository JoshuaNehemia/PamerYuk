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
    public partial class FormDaftarTeman : Form
    {
        private bool tag_konten;
        public FormDaftarTeman(bool konten)
        {
            InitializeComponent();
            this.tag_konten = konten;
        }

        private void FormDaftarTeman_Load(object sender, EventArgs e)
        {
            dataGridViewDaftarTeman.DataSource = FormUtama.service.ListTeman;
            if(dataGridViewDaftarTeman.Columns.Count ==3)
            {
                DataGridViewButtonColumn buttonLihatAkun = new DataGridViewButtonColumn();
                buttonLihatAkun.Text = "Lihat Profil";
                buttonLihatAkun.HeaderText = "Aksi";
                buttonLihatAkun.UseColumnTextForButtonValue = true;
                buttonLihatAkun.Name = "buttonLihatAkun";
                dataGridViewDaftarTeman.Columns.Add(buttonLihatAkun);
            }
            if(tag_konten)
            {
                DataGridViewButtonColumn buttonTambahTag = new DataGridViewButtonColumn();
                buttonTambahTag.Text = "Tambah Tag";
                buttonTambahTag.HeaderText = "Aksi";
                buttonTambahTag.UseColumnTextForButtonValue = true;
                buttonTambahTag.Name = "buttonTambahTag";
                dataGridViewDaftarTeman.Columns.Add(buttonTambahTag);
            }
        }

        private void dataGridViewDaftarTeman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDaftarTeman.Columns["buttonLihatAkun"].Index)
            {
                string username = dataGridViewDaftarTeman.CurrentRow.Cells["username"].Value.ToString();
                DateTime tglBerteman = DateTime.Parse(dataGridViewDaftarTeman.CurrentRow.Cells["tglBerteman"].Value.ToString());
                string status = dataGridViewDaftarTeman.CurrentRow.Cells["status"].Value.ToString();
                FormAkunTeman frm = new FormAkunTeman(new Teman(username, tglBerteman, status));
                frm.Owner = this;
                frm.ShowDialog();
            }
            if (e.ColumnIndex == dataGridViewDaftarTeman.Columns["buttonTambahAkun"].Index)
            {
                string username = dataGridViewDaftarTeman.CurrentRow.Cells["username"].Value.ToString();
                FormUtama.service.Tambah_Tag(username);
            }
        }
    }
}
