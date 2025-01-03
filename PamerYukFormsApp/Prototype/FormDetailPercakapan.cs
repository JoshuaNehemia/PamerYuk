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
    public partial class FormDetailPercakapan : Form
    {
        public string namaTeman;
        User pengirim;
        public FormDetailPercakapan()
        {
            InitializeComponent();
        }

        private void FormDetailPercakapan_Load(object sender, EventArgs e)
        {
            textBoxPesan.Clear();
            List<Chat> listChat = FormUtama.service.Buka_Chat(namaTeman);
            labelChatUsername.Text = namaTeman;            
            foreach(Chat chat in listChat)
            {                
                listBoxListChat.Items.Add(chat.Id+" "+chat.TglTerkirim + " " + chat.Pengirim + " : " + chat.Pesan);
            }
            //Agar chat terbaru selalu dibawah dan terlihat
            /*int visibleItems = listBoxListChat.ClientSize.Height / listBoxListChat.ItemHeight;
            listBoxListChat.TopIndex = Math.Max(listBoxListChat.Items.Count - visibleItems + 1, 0);*/
        }

        private void buttonKirim_Click(object sender, EventArgs e)
        {          
            try
            {                
                string message = textBoxPesan.Text;
                Chat newChat = new Chat(message, FormUtama.service.Current_user.Username, namaTeman);                
                FormUtama.service.Kirim_Chat(newChat);
                listBoxListChat.Items.Clear();
                FormDetailPercakapan_Load(sender, e);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
