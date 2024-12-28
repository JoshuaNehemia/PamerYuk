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

            dataGridViewDaftarTeman.DataSource = FormUtama.service.ListTeman;
            if (dataGridViewDaftarTeman.Columns.Count == 3)
            {
                DataGridViewButtonColumn buttonLihatChat = new DataGridViewButtonColumn();
                buttonLihatChat.Text = "Lihat Chat";
                buttonLihatChat.HeaderText = "Chat";
                buttonLihatChat.UseColumnTextForButtonValue = true;
                buttonLihatChat.Name = "buttonLihatChat";
                dataGridViewDaftarTeman.Columns.Add(buttonLihatChat);
            }

            /*//Agar chat terbaru selalu dibawah dan terlihat
            int visibleItems = listBoxListChat.ClientSize.Height / listBoxListChat.ItemHeight;
            listBoxListChat.TopIndex = Math.Max(listBoxListChat.Items.Count - visibleItems + 1, 0);*/
        }        

        private void dataGridViewDaftarTeman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDaftarTeman.Columns["buttonLihatChat"].Index)
            {
                string username = dataGridViewDaftarTeman.CurrentRow.Cells["username"].Value.ToString();               
                FormDetailPercakapan frm = new FormDetailPercakapan();
                frm.namaTeman = username;
                frm.Owner = this;
                frm.ShowDialog();
            }            
        }
    }
}
