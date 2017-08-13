using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Blog.Models.Mapping
{
    public class MakaleMap : EntityTypeConfiguration<Makale>
    {
        public MakaleMap()
        {
            // Primary Key
            this.HasKey(t => t.MakaleId);

            // Properties
            this.Property(t => t.Baslik)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Icerik)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Makale");
            this.Property(t => t.MakaleId).HasColumnName("MakaleId");
            this.Property(t => t.Baslik).HasColumnName("Baslik");
            this.Property(t => t.Icerik).HasColumnName("Icerik");
            this.Property(t => t.EklenmeTarihi).HasColumnName("EklenmeTarihi");
            this.Property(t => t.KategoriID).HasColumnName("KategoriID");
            this.Property(t => t.GorontulenmeSayisi).HasColumnName("GorontulenmeSayisi");
            this.Property(t => t.BegeniSayisi).HasColumnName("BegeniSayisi");
            this.Property(t => t.YazarID).HasColumnName("YazarID");
            this.Property(t => t.ResimID).HasColumnName("ResimID");

            // Relationships
            this.HasRequired(t => t.Kategori)
                .WithMany(t => t.Makales)
                .HasForeignKey(d => d.KategoriID);
            this.HasOptional(t => t.Resim)
                .WithMany(t => t.Makales)
                .HasForeignKey(d => d.ResimID);
            this.HasRequired(t => t.Yazar)
                .WithMany(t => t.Makales)
                .HasForeignKey(d => d.YazarID);

        }
    }
}
