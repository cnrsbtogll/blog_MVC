using System;
using System.Collections.Generic;

namespace Blog.Models
{
    public partial class Yazar
    {
        public Yazar()
        {
            this.Makales = new List<Makale>();
            this.Kullanicis = new List<Kullanici>();
        }

        public int YazarId { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
        public string MailAdres { get; set; }
        public string Aciklama { get; set; }
        public Nullable<bool> Cinsiyet { get; set; }
        public Nullable<int> ResimID { get; set; }
        public Nullable<int> RolID { get; set; }
        public Nullable<bool> Onaylandi { get; set; }
        public virtual ICollection<Makale> Makales { get; set; }
        public virtual Resim Resim { get; set; }
        public virtual Rol Rol { get; set; }
        public virtual ICollection<Kullanici> Kullanicis { get; set; }
    }
}
