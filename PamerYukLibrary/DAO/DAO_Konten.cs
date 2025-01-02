using MySql.Data.MySqlClient;
using PamerYukLibrary.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamerYukLibrary.DAO
{
    public class DAO_Konten
    {
        public static void Insert_Konten(Konten newKonten, string username)
        {
            int konten_id=Get_NewKonten_Id();
            string command = "INSERT INTO `pameryuk`.`konten` (`id`, `caption`, `foto`,`video`, `tglUpload`, `username`) VALUES ('"+konten_id+"', '"+newKonten.Caption+"', '"+newKonten.Foto+"', '"+newKonten.Video+"','"+newKonten.TglUpload.ToString("yyyy-MM-dd HH:mm:ss")+"', '"+username+"');";

            KoneksiDatabase.DatabaseDMLCommand(command);
        }

        public static List<Konten> Select_ListKonten(string username)
        {
            string perintah = "SELECT * from konten where username = '"+username+"';";

            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(perintah);
            List<Konten> listKonten = new List<Konten>();
            Konten konten;
            while (dr.Read())
            {
                //Konten
                int id = int.Parse(dr.GetValue(0).ToString());
                string caption = dr.GetValue(1).ToString();
                string foto = dr.GetValue(2).ToString();
                string video = dr.GetValue(3).ToString();
                DateTime tglUpload = DateTime.Parse(dr.GetValue(4).ToString());

                //Create Konten
                konten = new Konten (id, caption, foto, video, tglUpload);
                listKonten.Add(konten);
            }
            return listKonten;
        }
        public static Konten Select_Konten(int konten_id)
        {
            string perintah = "SELECT * from konten where id = '" + konten_id + "';";

            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(perintah);
            List<Konten> listKonten = new List<Konten>();
            Konten konten ;
            if (dr.Read())
            {
                //Konten
                int id = int.Parse(dr.GetValue(0).ToString());
                string caption = dr.GetValue(1).ToString();
                string foto = dr.GetValue(2).ToString();
                string video = dr.GetValue(3).ToString();
                DateTime tglUpload = DateTime.Parse(dr.GetValue(4).ToString());

                //Create Konten
                konten = new Konten(id, caption, foto, video, tglUpload);
                return konten;
            }
            else return null;
        }

        public static int Get_NewKonten_Id()
        {
            string command = "select id from konten order by id desc limit 1;";
            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(command);
            int newId=0;
            if(dr.Read())
            {
                newId = int.Parse(dr.GetValue(0).ToString());
            }
            return (newId + 1);
        }
    }
}
