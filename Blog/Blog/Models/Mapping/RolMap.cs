using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Blog.Models.Mapping
{
    public class RolMap : EntityTypeConfiguration<Rol>
    {
        public RolMap()
        {
            // Primary Key
            this.HasKey(t => t.RolId);

            // Properties
            this.Property(t => t.RolAdi)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Rol");
            this.Property(t => t.RolId).HasColumnName("RolId");
            this.Property(t => t.RolAdi).HasColumnName("RolAdi");
        }
    }
}
