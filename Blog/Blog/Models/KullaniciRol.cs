using System;
using System.Collections.Generic;

namespace Blog.Models
{
    public partial class KullaniciRol
    {
        public int KullaniciRolId { get; set; }
        public int RolID { get; set; }
        public int KullaniciId { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
