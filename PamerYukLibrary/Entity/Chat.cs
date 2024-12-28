using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamerYukLibrary.Entity
{
    public class Chat
    {
        private int id;
        private string pesan;
        private string pengirim;
        private string penerima;
        private DateTime tglTerkirim;

        public Chat(int id, string pesan, string pengirim, string penerima, DateTime tglTerkirim)
        {
            this.Id = id;
            this.Pesan = pesan;
            this.Pengirim = pengirim;
            this.Penerima = penerima;
            this.TglTerkirim = tglTerkirim;
        }

        public Chat(string pesan, string pengirim, string penerima) //for new chat
        {
            this.Pesan = pesan;
            this.Pengirim = pengirim;
            this.Penerima = penerima;
        }

        public int Id { get => id; set => id = value; }
        public string Pesan { get => pesan; set => pesan = value; }
        public string Pengirim { get => pengirim; set => pengirim = value; }
        public string Penerima { get => penerima; set => penerima = value; }
        public DateTime TglTerkirim { get => tglTerkirim; set => tglTerkirim = value; }

        public override string ToString()
        {
            return "[" + this.TglTerkirim.Date.ToString() + "] " +this.Pengirim + " -> " + this.Pesan + " ["+this.TglTerkirim.TimeOfDay.ToString() +"] "+ "\n";
        }
    }
}
