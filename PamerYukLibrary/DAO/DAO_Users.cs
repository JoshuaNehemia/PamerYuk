using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using MySql.Data.MySqlClient;
using PamerYukLibrary.Database;
using System.Diagnostics.Eventing.Reader;

namespace PamerYukLibrary.DAO
{
    public class DAO_Users
    {
        //This class exist to connect repositories to database

        //Users
        public static User User_Log_In(string username, string password)
        {
            string perintah = "SELECT * FROM user u inner join kota k on u.kota_id = k.id where username ='" + username + "' and password ='" + password + "';";

            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(perintah);

            User user;
            if (dr.Read())
            { 
                //User
                username = dr.GetValue(0).ToString();
                password = dr.GetValue(1).ToString();
                DateTime tgllahir = DateTime.Parse(dr.GetValue(2).ToString());
                string noKTP = dr.GetValue(3).ToString();
                string foto = dr.GetValue(4).ToString(); //Still confuse with this image data format
                int kota_id_fk = int.Parse(dr.GetValue(5).ToString());

                //Kota
                int kota_id = int.Parse(dr.GetValue(6).ToString());
                string nama = dr.GetValue(7).ToString();

                //Create Kota
                Kota newKota = new Kota(kota_id, nama);

                //Create User
                user = new User(username, password, tgllahir, noKTP, foto, newKota);
                user.ListKonten = DAO_Konten.Select_ListKonten(username);
                user.ListKisahHidup = DAO_KisahHidup.Select_ListKisahHidup(username);
                Console.WriteLine("Data user dari database berhasil diambil");
            }
            else
            {
                throw new Exception("User password or username is incorrect");
            }
            return user;
        }

        public static void User_Daftar(string username, string password, DateTime tglLahir, string noKTP, string foto, Kota kota)
        {
            string command = "INSERT INTO `pameryuk`.`user` (`username`, `password`, `tglLahir`, `noKTP`, `foto`, `Kota_id`) VALUES('"+username+"', '"+password+"', '"+tglLahir.ToString("yyyy-MM-dd")+"', '"+noKTP+"', '"+foto+"', '"+kota.Id+"');";
            KoneksiDatabase.DatabaseDMLCommand(command);
        }

        public static void Update_User()
        {
            string command = "UPDATE ";
            KoneksiDatabase.DatabaseDMLCommand(command);
        }



        public static List<User> Select_ListUser_ByUSN(string username)
        {
            string perintah = "SELECT * FROM user u inner join kota k on u.kota_id = k.id where username ='" + username + "';";

            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(perintah);
            List<User> listAkun = new List<User>();
            User user;
            while (dr.Read())
            {
                //User
                string usname = dr.GetValue(0).ToString();
                DateTime tgllahir = DateTime.Parse(dr.GetValue(2).ToString());
                string noKTP = dr.GetValue(3).ToString();
                string foto = dr.GetValue(4).ToString(); //Still confuse with this image data format
                int kota_id_fk = int.Parse(dr.GetValue(5).ToString());

                //Kota
                int kota_id = int.Parse(dr.GetValue(6).ToString());
                string nama = dr.GetValue(7).ToString();

                //Create Kota
                Kota newKota = new Kota(kota_id, nama);

                //Create User
                user = new User(usname, tgllahir, noKTP, foto, newKota);
                user.ListKonten = DAO_Konten.Select_ListKonten(username);
                user.ListKisahHidup = DAO_KisahHidup.Select_ListKisahHidup(username);
                listAkun.Add(user);
                Console.WriteLine("Data user dari database berhasil diambil");
            }
            return listAkun;
        }
        public static User Select_Tag_ByUSN(string username)
        {
            string perintah = "SELECT * FROM user u inner join kota k on u.kota_id = k.id where username ='" + username + "';";

            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(perintah);
            User user;
            if (dr.Read())
            {
                //User
                string usname = dr.GetValue(0).ToString();
                DateTime tgllahir = DateTime.Parse(dr.GetValue(2).ToString());
                string noKTP = dr.GetValue(3).ToString();
                string foto = dr.GetValue(4).ToString(); //Still confuse with this image data format
                int kota_id_fk = int.Parse(dr.GetValue(5).ToString());

                //Kota
                int kota_id = int.Parse(dr.GetValue(6).ToString());
                string nama = dr.GetValue(7).ToString();

                //Create Kota
                Kota newKota = new Kota(kota_id, nama);

                //Create User
                user = new User(usname, tgllahir, noKTP, foto, newKota);
                user.ListKonten = DAO_Konten.Select_ListKonten(username);
                user.ListKisahHidup = DAO_KisahHidup.Select_ListKisahHidup(username);
                Console.WriteLine("Data user dari database berhasil diambil");
                return user;
            }
            else return null;
        }
        public static User Select_User(string username)
        {
            string perintah = "SELECT * FROM user u inner join kota k on u.kota_id = k.id where username ='" + username + "';";

            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(perintah);
            User user;
            if (dr.Read())
            {
                //User
                string usname = dr.GetValue(0).ToString();
                DateTime tgllahir = DateTime.Parse(dr.GetValue(2).ToString());
                string noKTP = dr.GetValue(3).ToString();
                string foto = dr.GetValue(4).ToString(); //Still confuse with this image data format
                int kota_id_fk = int.Parse(dr.GetValue(5).ToString());

                //Kota
                int kota_id = int.Parse(dr.GetValue(6).ToString());
                string nama = dr.GetValue(7).ToString();

                //Create Kota
                Kota newKota = new Kota(kota_id, nama);

                //Create User
                user = new User(usname, tgllahir, noKTP, foto, newKota);
                user.ListKonten = DAO_Konten.Select_ListKonten(username);
                user.ListKisahHidup = DAO_KisahHidup.Select_ListKisahHidup(username);
                return user;
            }
            else return null;
        }

        public static List<User> Select_ListUser_ByOrganisasi(Organisasi organisasi, User current_user)
        {
            string command = "SELECT u.username, u.tgllahir, u.noktp, u.foto, u.kota_id, ko.nama FROM user u inner join kisahhidup k on  u.username = k.username inner join kota ko on u.kota_id = ko.id where k.organisasi_id = '"+organisasi.Id+ "' and k.username != '"+current_user.Username+"';";

            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(command);
            List<User> listAkun = new List<User>();
            User user;
            while (dr.Read())
            {
                //User
                string usname = dr.GetValue(0).ToString();
                DateTime tgllahir = DateTime.Parse(dr.GetValue(1).ToString());
                string noKTP = dr.GetValue(2).ToString();
                string foto = dr.GetValue(3).ToString(); //Still confuse with this image data format
                int kota_id_fk = int.Parse(dr.GetValue(4).ToString());

                //Kota
                string nama = dr.GetValue(5).ToString();

                //Create Kota
                Kota newKota = new Kota(kota_id_fk, nama);

                //Create User
                user = new User(usname, tgllahir, noKTP, foto, newKota);
                user.ListKonten = DAO_Konten.Select_ListKonten(usname);
                user.ListKisahHidup = DAO_KisahHidup.Select_ListKisahHidup(usname);
                listAkun.Add(user);
                Console.WriteLine("Data user dari database berhasil diambil");
            }
            return listAkun;

        }
    }
}
