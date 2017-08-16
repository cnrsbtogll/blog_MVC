using System;
using System.Collections.Generic;

namespace Blog.Models
{
    public partial class Rol
    {
        public Rol()
        {
            this.Kullanicis = new List<Kullanici>();
            this.Yazars = new List<Yazar>();
        }

        public int RolId { get; set; }
        public string RolAdi { get; set; }
        public virtual ICollection<Kullanici> Kullanicis { get; set; }
        public virtual ICollection<Yazar> Yazars { get; set; }
    }
}
