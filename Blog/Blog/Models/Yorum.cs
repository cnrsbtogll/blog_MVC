using System;
using System.Collections.Generic;

namespace Blog.Models
{
    public partial class Yorum
    {
        public int YorumId { get; set; }
        public string Yorum1 { get; set; }
        public int MakaleID { get; set; }
        public Nullable<System.DateTime> EklenemeTarihi { get; set; }
        public string AdSoyad { get; set; }
        public Nullable<int> Begeni { get; set; }
        public virtual Makale Makale { get; set; }
    }
}