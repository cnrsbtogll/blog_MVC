using System;
using System.Collections.Generic;

namespace Blog.Models
{
    public partial class Rol
    {
        public Rol()
        {
            this.KullaniciRols = new List<KullaniciRol>();
        }

        public int RolId { get; set; }
        public string RolAdi { get; set; }
        public virtual ICollection<KullaniciRol> KullaniciRols { get; set; }
    }
}
