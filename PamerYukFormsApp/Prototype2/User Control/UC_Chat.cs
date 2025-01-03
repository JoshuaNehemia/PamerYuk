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
    public partial class UC_Chat : UserControl
    {
        MainForm mainForm;
        public UC_Chat(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void UC_Chat_Load(object sender, EventArgs e)
        {
            mainForm.panel1.Show();
            mainForm.panel1.BringToFront();
        }
    }
}
