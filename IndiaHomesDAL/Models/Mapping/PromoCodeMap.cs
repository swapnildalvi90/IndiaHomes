using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace IndiaHomesDAL.Models.Mapping
{
    public class PromoCodeMap : EntityTypeConfiguration<PromoCode>
    {
        public PromoCodeMap()
        {
            // Primary Key
            this.HasKey(t => t.PromoId);

            // Properties
            this.Property(t => t.PromoId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PromoCode");
            this.Property(t => t.PromoId).HasColumnName("PromoId");
            this.Property(t => t.MaxDisc).HasColumnName("MaxDisc");
            this.Property(t => t.MinAmount).HasColumnName("MinAmount");
            this.Property(t => t.ValidToDate).HasColumnName("ValidToDate");
            this.Property(t => t.ValidFromDate).HasColumnName("ValidFromDate");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.TypeOfCode).HasColumnName("TypeOfCode");
        }
    }
}
