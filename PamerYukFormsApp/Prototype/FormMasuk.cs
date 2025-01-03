using PamerYukLibrary;
using PamerYukLibrary.DAO;
using PamerYukLibrary.Database;
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
    public partial class FormMasuk : Form
    {
        FormUtama formUtama;
        public FormMasuk()
        {
            InitializeComponent();
        }

        private void FormMasuk_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama)this.Owner;                               
        }
                
        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            FormDaftar formDaftar = new FormDaftar();
            formDaftar.Owner = this;
            formDaftar.ShowDialog();
            if(FormUtama.service.Current_user!=null)
            {
                textBoxUsername.Text = FormUtama.service.Current_user.Username;
            }
        }             

        private void buttonMasuk_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;
                Console.WriteLine(username + ":" + password);
                FormUtama.service.LogIn(username, password);
                this.Close();
                formUtama.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
