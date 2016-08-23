using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace IndiaHomesDAL.Models.Mapping
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            // Primary Key
            this.HasKey(t => t.BookingNumber);

            // Properties
            this.Property(t => t.Status)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Username)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Order");
            this.Property(t => t.BookingNumber).HasColumnName("BookingNumber");
            this.Property(t => t.CustomerId).HasColumnName("CustomerId");
            this.Property(t => t.CheckInDate).HasColumnName("CheckInDate");
            this.Property(t => t.CheckOutDate).HasColumnName("CheckOutDate");
            this.Property(t => t.Cost).HasColumnName("Cost");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.HotelId).HasColumnName("HotelId");
            this.Property(t => t.RoomId).HasColumnName("RoomId");
            this.Property(t => t.Username).HasColumnName("Username");
            this.Property(t => t.AddedDate).HasColumnName("AddedDate");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasOptional(t => t.Account)
                .WithMany(t => t.Orders)
                .HasForeignKey(d => d.Username);
            this.HasRequired(t => t.Customer)
                .WithMany(t => t.Orders)
                .HasForeignKey(d => d.CustomerId);
            this.HasRequired(t => t.HotelRoom)
                .WithMany(t => t.Orders)
                .HasForeignKey(d => new { d.RoomId, d.HotelId });

        }
    }
}
