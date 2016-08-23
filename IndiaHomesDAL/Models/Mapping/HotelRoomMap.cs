using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace IndiaHomesDAL.Models.Mapping
{
    public class HotelRoomMap : EntityTypeConfiguration<HotelRoom>
    {
        public HotelRoomMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RoomId, t.HotelId });

            // Properties
            this.Property(t => t.RoomId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HotelId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TypeName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("HotelRoom");
            this.Property(t => t.RoomId).HasColumnName("RoomId");
            this.Property(t => t.HotelId).HasColumnName("HotelId");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.ImageUrl).HasColumnName("ImageUrl");
            this.Property(t => t.TypeName).HasColumnName("TypeName");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Hotel)
                .WithMany(t => t.HotelRooms)
                .HasForeignKey(d => d.HotelId);

        }
    }
}
