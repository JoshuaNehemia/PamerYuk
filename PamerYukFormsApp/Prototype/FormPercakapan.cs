using PamerYukLibrary;
using PamerYukLibrary.Entity;
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
    public partial class FormPercakapan : Form
    {
        private User temanChat;
        public FormPercakapan(User temanChat)
        {
            InitializeComponent();
            this.temanChat = temanChat;
        }

        private void FormPercakapan_Load(object sender, EventArgs e)
        {
            labelTeman.Text = this.temanChat.Username;
            listBoxListChat.DataSource = FormUtama.service.Buka_Chat(this.temanChat.Username); //Dari Database


            //Agar chat terbaru selalu dibawah dan terlihat
            int visibleItems = listBoxListChat.ClientSize.Height / listBoxListChat.ItemHeight;
            listBoxListChat.TopIndex = Math.Max(listBoxListChat.Items.Count - visibleItems + 1, 0);
        }

        private void buttonKirim_Click(object sender, EventArgs e)
        {
            string message = textBoxPesan.Text;
            Chat newChat = new Chat(message, FormUtama.service.Current_user.Username, this.temanChat.Username);
            FormUtama.service.Kirim_Chat(newChat);
            textBoxPesan.Clear();
            textBoxPesan.Focus();
            FormPercakapan_Load(sender, e);
        }
    }
}
