using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PamerYukFormsApp.Prototype2.User_Control
{
    public partial class UC_DaftarUsername : UserControl
    {
        MainForm mainForm;
        public UC_DaftarUsername(MainForm mainForm)
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

        private void buttonLanjut_Click(object sender, EventArgs e)
        {
            if(textBoxUsername.Text != "" && textBoxPassword.Text != "" && textBoxConfirmPassword.Text != "")
            {
                if (textBoxPassword.Text == textBoxConfirmPassword.Text)
                {
                    UC_DaftarDataDiri uc_dataDiri = new UC_DaftarDataDiri(mainForm);
                    uc_dataDiri.username = textBoxUsername.Text;
                    uc_dataDiri.password = textBoxPassword.Text;
                    uc_dataDiri.confirm_password = textBoxConfirmPassword.Text;
                    mainForm.panelUtama.Controls.Remove(this);
                    mainForm.panelUtama.Controls.Add(uc_dataDiri);
                }
                else
                {
                    MessageBox.Show("Please make sure password and confirmation password have the same value");
                }
            }
            else
            {
                MessageBox.Show("All the data must be filled");
            }
            
        }

        private void UC_DaftarUsername_Load(object sender, EventArgs e)
        {
            textBoxUsername.Focus();
        }
    }
}
