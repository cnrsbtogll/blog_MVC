using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Blog.Models.Mapping;

namespace Blog.Models
{
    public partial class blog_iozContext : DbContext
    {
        static blog_iozContext()
        {
            Database.SetInitializer<blog_iozContext>(null);
        }

        public blog_iozContext()
            : base("Name=blog_iozContext")
        {
        }

        public DbSet<Etiket> Etikets { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<Makale> Makales { get; set; }
        public DbSet<Resim> Resims { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Yazar> Yazars { get; set; }
        public DbSet<Yorum> Yorums { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EtiketMap());
            modelBuilder.Configurations.Add(new KategoriMap());
            modelBuilder.Configurations.Add(new KullaniciMap());
            modelBuilder.Configurations.Add(new MakaleMap());
            modelBuilder.Configurations.Add(new ResimMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new YazarMap());
            modelBuilder.Configurations.Add(new YorumMap());
        }
    }
}
