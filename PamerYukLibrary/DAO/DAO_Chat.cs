using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using PamerYukLibrary.Database;
using PamerYukLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamerYukLibrary.DAO
{
    public class DAO_Chat
    {
        public static List<Chat> Select_Chat(string friend, string user)
        {
            //usn2 is current user
            string perintah = "SELECT * FROM chat  WHERE pengirim = '" + friend + "' and penerima ='" + user + "' UNION SELECT * FROM chat  WHERE pengirim = '" + user + "' and penerima ='" + friend + "';";
            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(perintah);
            List<Chat> listChat = new List<Chat>();
            while (dr.Read())
            {
                int id = int.Parse(dr.GetValue(0).ToString());
                string pesan = dr.GetValue(1).ToString();
                DateTime tglTerkirim = DateTime.Parse(dr.GetValue(2).ToString());
                string pengirim = dr.GetValue(3).ToString();
                string penerima = dr.GetValue(4).ToString();
                Chat newChat = new Chat(id,pesan,pengirim,penerima,tglTerkirim);
                listChat.Add(newChat);
            }
            return listChat;
        }

        public static void Insert_Chat(Chat chat)
        {
            string command = "INSERT INTO `pameryuk`.`chat` (`id`, `pesan`,'tglTerkirim', `pengirim`,`penerima`) VALUES ('" + Get_NewChat_Id() + "', '" + chat.Pesan + "','" + DateTime.Now.Date.ToString("yyyy-MM-dd HH:mm:ss") + "','" + chat.Pengirim + "','" + chat.Penerima +"';";
            KoneksiDatabase.DatabaseDMLCommand(command);
        }

        private static int Get_NewChat_Id()
        {
            int result=0;//for sementara
            string perintah = "SELECT id FROM chat ORDER BY id DESC LIMIT 1;";
            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(perintah);
            if (dr.Read())
            {
                result = int.Parse(dr.GetValue(0).ToString());
            }
            return (result+1);
        }
    }
}
