using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PamerYukFormsApp.Prototype;
using PamerYukLibrary;


//PamerYuk Library
using PamerYukLibrary.Database;

namespace PamerYukFormsApp
{
    public partial class FormUtama : Form
    {
        public static Service service = new Service();
        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {

            this.IsMdiContainer = true;
            try
            {
                KoneksiDatabase connectToDatabase = new KoneksiDatabase(PamerYuk.Default.Server, PamerYuk.Default.Database, PamerYuk.Default.User, PamerYuk.Default.Password);
                MessageBox.Show("Koneksi ke Database Berhasil.\n" + "Terhubung dengan, " + PamerYuk.Default.Server + " : " + PamerYuk.Default.Database);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi ke Database Gagal : \n" + ex.Message);
            }
            FormMasuk formMasuk = new FormMasuk();
            formMasuk.Owner = this;
            formMasuk.ShowDialog();
            if (service.Current_user == null) //If user not logged in
            {
                Application.Exit();
            }

            service.OnLoad();
        }

        private void profilSayaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FormAkun"];
            if (f == null)
            {
                FormAkun frm = new FormAkun();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.BringToFront();
                f.MaximizeBox = true;
            }
        }

        private void tambahKisahHidupToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form f = Application.OpenForms["FormKisahHidup"];
            if (f == null)
            {
                FormKisahHidup frm = new FormKisahHidup();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.BringToFront();
                f.MaximizeBox = true;
            }
        }

        private void cariTemanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FormTeman"];
            if (f == null)
            {
                FormTeman frm = new FormTeman();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.BringToFront();
                f.MaximizeBox = true;
            }
        }

        private void kontenSayaToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Form f = Application.OpenForms["FormDaftarKonten"];
            if (f == null)
            {
                FormDaftarKonten frm = new FormDaftarKonten(service.Current_user);
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.BringToFront();
                f.MaximizeBox = true;
            }
        }

        private void tambahKontenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form f = Application.OpenForms["FormTambahKonten"];
            if (f == null)
            {
                FormTambahKonten frm = new FormTambahKonten();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.BringToFront();
                f.MaximizeBox = true;
            }
        }

        private void daftarKontenSayaToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Form f = Application.OpenForms["FormDaftarKonten"];
            if (f == null)
            {
                FormTambahKonten frm = new FormTambahKonten();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.BringToFront();
                f.MaximizeBox = true;
            }
        }

        private void daftarTemanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FormDaftarTeman"];
            if (f == null)
            {
                FormDaftarTeman frm = new FormDaftarTeman(false);
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.BringToFront();
                f.MaximizeBox = true;
            }
        }

        private void requestPertemananToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FormRequestPertemanan"];
            if (f == null)
            {
                FormRequestPertemanan frm = new FormRequestPertemanan();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.BringToFront();
                f.MaximizeBox = true;
            }
        }

        private void percakapanSayaToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Form f = Application.OpenForms["FormPercakapan"];
            if (f == null)
            {
                FormPercakapan frm = new FormPercakapan(service.Current_user);
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.BringToFront();
                f.MaximizeBox = true;
            }
        }
    }
}
