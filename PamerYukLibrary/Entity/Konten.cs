using PamerYukLibrary.DAO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace PamerYukLibrary
{
    public class Konten
    {
        private int id;
        private string caption;
        private string foto;
        private string video;
        private DateTime tglUpload;
        private List<User> tag;
        private int like;
        private List<Komen> comment;

        public Konten(int id, string caption, string foto, string video, DateTime tglUpload)
        {
            this.Id = id;
            this.Caption = caption;
            this.Foto = foto;
            this.Video = video;
            this.TglUpload = tglUpload;
            this.Comment = DAO_Komen.Select_Komen(this.Id);
            this.Tag = DAO_Tag.Select_Tag(this.Id);
            this.Like = DAO_Like.Select_LikeCount(this.Id);
        }
        public Konten( string caption, string foto, string video, DateTime tglUpload,List<User> tag) //New Konten
        {
            this.Caption = caption;
            this.Foto = foto;
            this.Video = video;
            this.TglUpload = tglUpload;
            this.Tag = tag;
        }

        public int Id { get => id; set => id = value; }
        public string Caption { get => caption; set => caption = value; }
        public string Foto { get => foto; set => foto = value; }
        public string Video { get => video; set => video = value; }
        public DateTime TglUpload { get => tglUpload; set => tglUpload = value; }
        public List<User> Tag { get => tag; set => tag = value; }
        public int Like { get=>like; set => like = value; }
        public List<Komen> Comment { get => comment; set => comment = value; }
    }
}