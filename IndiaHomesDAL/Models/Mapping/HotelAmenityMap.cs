using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace IndiaHomesDAL.Models.Mapping
{
    public class HotelAmenityMap : EntityTypeConfiguration<HotelAmenity>
    {
        public HotelAmenityMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AmenityId, t.HotelId });

            // Properties
            this.Property(t => t.AmenityId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HotelId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("HotelAmenities");
            this.Property(t => t.AmenityId).HasColumnName("AmenityId");
            this.Property(t => t.HotelId).HasColumnName("HotelId");
        }
    }
}
