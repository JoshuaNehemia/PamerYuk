using PamerYukLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PamerYukLibrary;
using PamerYukLibrary.DAO;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PamerYukFormsApp
{
    public class Service //On Load
    {
        #region VARIABLES
        private User current_user;
        private List<Kota> listKota;
        private List<Organisasi> listOrganisasi;
        private List<Teman> listTeman;

        private string MediafilePath = @"C:\PamerYuk\";
        private string MediafilePathDB = @"C:\\PamerYuk\\";
        #endregion

        #region CONSTRUCTOR
        public Service()
        {
            this.ListOrganisasi = DAO_Organisasi.Select_Organisasi();
            this.ListKota = DAO_Kota.Select_ListKota();
        }
        #endregion

        #region PROPERTIES

        public User Current_user { get => current_user; set => current_user = value; }
        public List<Kota> ListKota { get => listKota; set => listKota = value; }
        public List<Organisasi> ListOrganisasi { get => listOrganisasi; set => listOrganisasi = value; }
        public List<Teman> ListTeman { get => listTeman; set => listTeman = value; }
        #endregion

        #region ONLOAD
        public void OnLoad()
        {
            this.ListTeman = DAO_Teman.Select_ListTeman(this.Current_user.Username);
        }
        #endregion

        #region METHOD (USER) 
        //For User
        public void LogIn(string username, string password)
        {
            this.Current_user = DAO_Users.User_Log_In(username, password);
        }

        public User Daftar(string username, string password, DateTime tglLahir, string noKTP, string foto, Kota kota)
        {
            User new_user = new User(username, password, tglLahir, noKTP, foto, kota);                       
            DAO_Users.User_Daftar(username, password, tglLahir, noKTP, foto, kota);
            return new_user;
        }        

        #endregion

        #region METHOD (KISAH HIDUP)
        //For Kisah Hidup
        public void Tambah_KisahHidup(KisahHidup newKisahHidup)
        {
            DAO_KisahHidup.Insert_KisahHidup(newKisahHidup, this.Current_user);
            this.current_user.ListKisahHidup = DAO_KisahHidup.Select_ListKisahHidup(this.Current_user.Username);
        }

        #endregion

        #region METHOD (ORGANISASI)
        public void Tambah_Organisasi(Organisasi newOrganisasi)
        {
            DAO_Organisasi.Insert_Organisasi(newOrganisasi);
            this.ListOrganisasi = DAO_Organisasi.Select_Organisasi(); //Re-New the list
        }

        #endregion

        #region METHOD (TEMAN)
        public List<User> Cari_Teman(Organisasi organisasi)
        {
            return DAO_Users.Select_UserTeman_ByOrganisasi(organisasi, this.Current_user);
        }

        public List<User> Cari_Teman(string username)
        {
            return DAO_Users.Select_UserTeman_ByUSN(username);
        }

        public User Cari_AkunTeman(string username)
        {
            return DAO_Users.Select_AkunTeman(username);
        }

        public void Request_Pertemanan(string username)
        {
            DAO_Teman.Insert_RequestPertemanan(this.Current_user.Username, username);
        }

        public void Terima_Pertemanan(string username)
        {
            DAO_Teman.Update_RequestPertemanan(username, this.Current_user.Username, "Berteman");
        }

        public void Tolak_Pertemanan(string username)
        {
            DAO_Teman.Update_RequestPertemanan(username, this.Current_user.Username, "Ditolak");
        }
        public void KirimUlang_Pertemanan(string username)
        {
            DAO_Teman.Update_RequestPertemanan(username, this.Current_user.Username, "Menunggu");
        }

        public List<Teman> Request_Pertemanan(bool jenis)
        {
            //true = sender, false = receiver
            return DAO_Teman.Select_RequestPertemanan(this.Current_user.Username, jenis);
        }
        #endregion

        #region METHOD (KONTEN)
        public Konten Tambah_Komen(Komen komen, Konten newKonten)
        {
            DAO_Komen.Insert_Komen(komen,newKonten.Id);
            newKonten.Comment = DAO_Komen.Select_Komen(newKonten.Id);
            return newKonten;
        }

        public Konten Lihat_Konten(int id)
        {
            return DAO_Konten.Select_Konten(id);
        }

        public void Tambah_Konten(string caption, OpenFileDialog fdialog)
        {
            Konten newKonten;
            string newPath = "";
            if (Path.GetExtension(fdialog.FileName) == ".jpg")
            {
                newPath = New_FileName(true);
                newKonten = new Konten(caption, Path.Combine(this.MediafilePathDB,newPath), "null",DateTime.Now);
            }
            else
            {
                newPath = New_FileName(false);
                newKonten = new Konten(caption, "null", Path.Combine(this.MediafilePathDB, newPath), DateTime.Now);
            }
            File.Copy(fdialog.FileName, Path.Combine(this.MediafilePath, newPath));
            DAO_Konten.Insert_Konten(newKonten, this.Current_user.Username);
            this.Current_user.ListKonten = DAO_Konten.Select_ListKonten(this.current_user.Username);
        }
        private string New_FileName(bool type)
        {

            string path = this.current_user.Username + "x" + DateTime.Now.ToString("yyyyMMddHHmmss") + "x" + DAO_Konten.Get_NewKonten_Id();
            if (type)
            {
                path += ".jpg";
            }
            else
            {
                path += ".mp4";
            }
            return path;
        }
        #endregion
    }
}
