using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Blog.Models.Mapping
{
    public class KullaniciRolMap : EntityTypeConfiguration<KullaniciRol>
    {
        public KullaniciRolMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RolID, t.KullaniciId });

            // Properties
            this.Property(t => t.KullaniciRolId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.RolID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.KullaniciId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("KullaniciRol");
            this.Property(t => t.KullaniciRolId).HasColumnName("KullaniciRolId");
            this.Property(t => t.RolID).HasColumnName("RolID");
            this.Property(t => t.KullaniciId).HasColumnName("KullaniciId");

            // Relationships
            this.HasRequired(t => t.Kullanici)
                .WithMany(t => t.KullaniciRols)
                .HasForeignKey(d => d.KullaniciId);
            this.HasRequired(t => t.Rol)
                .WithMany(t => t.KullaniciRols)
                .HasForeignKey(d => d.RolID);

        }
    }
}
