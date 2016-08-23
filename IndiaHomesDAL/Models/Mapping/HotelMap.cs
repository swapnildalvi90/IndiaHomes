using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace IndiaHomesDAL.Models.Mapping
{
    public class HotelMap : EntityTypeConfiguration<Hotel>
    {
        public HotelMap()
        {
            // Primary Key
            this.HasKey(t => t.HotelId);

            // Properties
            this.Property(t => t.HotelId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Hotel");
            this.Property(t => t.HotelId).HasColumnName("HotelId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.ImageUrl).HasColumnName("ImageUrl");
            this.Property(t => t.Ratings).HasColumnName("Ratings");
            this.Property(t => t.Longitude).HasColumnName("Longitude");
            this.Property(t => t.Latitude).HasColumnName("Latitude");
            this.Property(t => t.AddressId).HasColumnName("AddressId");

            // Relationships
            this.HasOptional(t => t.Address)
                .WithMany(t => t.Hotels)
                .HasForeignKey(d => d.AddressId);

        }
    }
}
