using System;
using System.Collections.Generic;

namespace Blog.Models
{
    public partial class Resim
    {
        public Resim()
        {
            this.Makales = new List<Makale>();
            this.Yazars = new List<Yazar>();
        }

        public int ResimId { get; set; }
        public string KucukBoyut { get; set; }
        public string OrtaBoyut { get; set; }
        public string BuyukBoyut { get; set; }
        public string Video { get; set; }
        public Nullable<int> MakaleID { get; set; }
        public virtual ICollection<Makale> Makales { get; set; }
        public virtual Makale Makale { get; set; }
        public virtual ICollection<Yazar> Yazars { get; set; }
    }
}
