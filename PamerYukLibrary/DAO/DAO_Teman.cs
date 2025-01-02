using MySql.Data.MySqlClient;
using PamerYukLibrary.Database;
using PamerYukLibrary.Value;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamerYukLibrary.DAO
{
    public class DAO_Teman
    {
        //In DB usn1 is the sender, usn2 is the receiver
        
        public static List<Teman> Select_ListTeman(string username)
        {
            string perintah;
            perintah = "SELECT * FROM teman  WHERE teman.username1 = '"+username+"' and teman.StatusPertemanan = 'Berteman' UNION SELECT * FROM teman WHERE teman.username2 = '"+username+ "'and teman.StatusPertemanan = 'Berteman';";
            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(perintah);
            List<Teman> listTeman = new List<Teman>();
            while (dr.Read())
            {
                //Teman
                string username1 = dr.GetValue(0).ToString();
                string username2 = dr.GetValue(1).ToString();
                DateTime tglBerteman = DateTime.Parse(dr.GetValue(2).ToString());
                string status = dr.GetValue(3).ToString();

                string friendUSN = username1;
                if(friendUSN == username)
                {
                    friendUSN = username2;
                }

                //Create Teman(buffer)
                Teman newTeman = new Teman(friendUSN,tglBerteman,status);

                //Add to list teman
                listTeman.Add(newTeman);

            }
            return listTeman;
        }

        public static void Insert_RequestPertemanan(string username1, string username2)
        {
            string command = "INSERT INTO `pameryuk`.`teman` (`username1`, `username2`,`tglberteman`, `statusPertemanan`) VALUES ('"+username1+"', '"+username2+"','"+ DateTime.Now.Date.ToString("yyyy-MM-dd") + "','Menunggu');";
            KoneksiDatabase.DatabaseDMLCommand(command);
        }

        public static void Update_RequestPertemanan(string username1, string username2, string statusRequest)
        {
            string command = "UPDATE teman set statusPertemanan = '"+statusRequest+"', tglberteman = '"+DateTime.Now.Date.ToString("yyyy-MM-dd")+"' where username1 = '"+username1+"' and username2= '"+username2+"';";
            KoneksiDatabase.DatabaseDMLCommand(command);
        }

        public static List<Teman> Select_RequestPertemanan(string username, bool jenis)
        {
            string perintah;
            if(jenis == true)
                perintah = "SELECT * FROM teman  WHERE teman.username1 = '" + username + "' and teman.StatusPertemanan != 'Berteman';";
            else
                perintah = "SELECT * FROM teman  WHERE teman.username2 = '" + username + "' and teman.StatusPertemanan != 'Berteman';";

            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(perintah);
            List<Teman> listTeman = new List<Teman>();
            while (dr.Read())
            {
                //Teman
                string username1 = dr.GetValue(0).ToString();
                string username2 = dr.GetValue(1).ToString();
                DateTime tglBerteman = DateTime.Parse(dr.GetValue(2).ToString());
                string status = dr.GetValue(3).ToString();

                string friendUSN = username1;
                if (friendUSN == username)
                {
                    friendUSN = username2;
                }

                //Create Teman(buffer)
                Teman newTeman = new Teman(friendUSN, tglBerteman, status);

                //Add to list teman
                listTeman.Add(newTeman);

            }
            return listTeman;
        }
    }
}
