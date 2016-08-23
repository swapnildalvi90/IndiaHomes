using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace IndiaHomesDAL.Models.Mapping
{
    public class AmenityMap : EntityTypeConfiguration<Amenity>
    {
        public AmenityMap()
        {
            // Primary Key
            this.HasKey(t => t.AmenityId);

            // Properties
            this.Property(t => t.AmenityId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AmenityName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Amenities");
            this.Property(t => t.AmenityId).HasColumnName("AmenityId");
            this.Property(t => t.AmenityName).HasColumnName("AmenityName");
        }
    }
}
