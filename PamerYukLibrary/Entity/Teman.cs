using PamerYukLibrary.Value;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using PamerYukLibrary.Entity;

namespace PamerYukLibrary
{
    public class Teman
    {
        private string username;
        private DateTime tglBerteman;
        private string status;
        public Teman(string username, DateTime tglBerteman, string status)
        {
            this.Username = username;
            this.TglBerteman = tglBerteman;
            this.Status = status;
        }

        public string Username { get => username; set => username = value; }
        public DateTime TglBerteman { get => tglBerteman; set => tglBerteman = value; }
        public string Status { get => status; set => status = value; }
    }
}