using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using PamerYukLibrary.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PamerYukLibrary.DAO
{
    public class DAO_Like
    {
        public static int Select_LikeCount(int konten_id)
        {
            string command = "SELECT count(username) FROM pameryuk.`like` where konten_id = '" + konten_id + "';";
            int result = 0;
            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(command);
            if (dr.Read())
            {
                result = int.Parse(dr.GetValue(0).ToString());
            }
            return result;
        }
        public static bool CheckLike(int konten_id, string username)
        {
            string command = "SELECT count(username) FROM pameryuk.`like` where konten_id = '" + konten_id + "' and username = '" + username + "';";
            int result = 0;
            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(command);
            if (dr.Read())
            {
                result = int.Parse(dr.GetValue(0).ToString());
            }
            if(result !=0)
            {
                return true;
            }
            else return false;
        }

        public static void Insert_Like(int konten_id, string username)
        {
            //Check dulu kalau udah di like tinggal do nothing(di service harusnya) cuma kucatet bentar disini soalnya servis belum kubuat hehe
            string command = "INSERT INTO `pameryuk`.`like` (`Konten_id`, `username`) VALUES ('" + konten_id + "', '" + username + "');";
            KoneksiDatabase.DatabaseDMLCommand(command);
        }
        public static void DELETE_Like(int konten_id, string username)
        {
            //Check dulu kalau udah di like tinggal do nothing(di service harusnya) cuma kucatet bentar disini soalnya servis belum kubuat hehe
            string command = "DELETE FROM `pameryuk`.`like` where konten_id = '" + konten_id + "' and username ='" + username + "';";
            KoneksiDatabase.DatabaseDMLCommand(command);
        }
    }
}
