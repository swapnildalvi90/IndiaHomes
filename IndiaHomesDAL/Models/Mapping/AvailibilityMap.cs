using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace IndiaHomesDAL.Models.Mapping
{
    public class AvailibilityMap : EntityTypeConfiguration<Availibility>
    {
        public AvailibilityMap()
        {
            // Primary Key
            this.HasKey(t => new { t.HotelId, t.RoomId, t.CheckInDate, t.CheckOutDate });

            // Properties
            this.Property(t => t.HotelId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RoomId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Availibility");
            this.Property(t => t.HotelId).HasColumnName("HotelId");
            this.Property(t => t.RoomId).HasColumnName("RoomId");
            this.Property(t => t.CheckInDate).HasColumnName("CheckInDate");
            this.Property(t => t.CheckOutDate).HasColumnName("CheckOutDate");

            // Relationships
            this.HasRequired(t => t.HotelRoom)
                .WithMany(t => t.Availibilities)
                .HasForeignKey(d => new { d.RoomId, d.HotelId });

        }
    }
}
