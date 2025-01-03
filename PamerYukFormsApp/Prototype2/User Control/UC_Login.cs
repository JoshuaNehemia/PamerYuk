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
using PamerYukLibrary.DAO;

namespace PamerYukFormsApp.Prototype2.User_Control
{
    public partial class UC_Login : UserControl
    {
        public bool confirmLogin = false;
        MainForm mainForm;
        public UC_Login(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.mainForm.panel1.Hide();
        }

        private void UC_Login_Load(object sender, EventArgs e)
        {
            textBoxUsername.Focus();            
            //Biar g bisa resize forms nya manual (bisa resize wkt user udh login
            mainForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            mainForm.MaximizeBox = false;
            mainForm.MinimizeBox = false;
        }

        private void buttonMasuk_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;
                Console.WriteLine(username + ":" + password);
                FormUtama.service.LogIn(username, password);
                confirmLogin = true;
                
                //Proses login selesai, User Control close, Clear object yg show di panelUtama
                mainForm.panelUtama.Controls.Remove(this);
                UC_Home uc_home = new UC_Home(mainForm);
                mainForm.panelUtama.Controls.Add(uc_home);

                /*mainForm.panelUtama.Show();*/
                mainForm.FormBorderStyle = FormBorderStyle.Sizable;
                mainForm.MaximizeBox = true;
                mainForm.MinimizeBox = true;

                mainForm.panel1.Show();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            UC_DaftarUsername uC_Daftar = new UC_DaftarUsername(mainForm);
            mainForm.panelUtama.Controls.Remove(this);
            mainForm.panelUtama.Controls.Add(uC_Daftar);
        }
    }
}
