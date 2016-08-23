using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace IndiaHomesDAL.Models.Mapping
{
    public class AppExceptionMap : EntityTypeConfiguration<AppException>
    {
        public AppExceptionMap()
        {
            // Primary Key
            this.HasKey(t => t.ExceptionId);

            // Properties
            this.Property(t => t.SessionId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Exception)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("AppException");
            this.Property(t => t.SessionId).HasColumnName("SessionId");
            this.Property(t => t.Exception).HasColumnName("Exception");
            this.Property(t => t.Timestamp).HasColumnName("Timestamp");
            this.Property(t => t.Message).HasColumnName("Message");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.ExceptionId).HasColumnName("ExceptionId");
            this.Property(t => t.InnerException).HasColumnName("InnerException");
            this.Property(t => t.StackTrace).HasColumnName("StackTrace");
        }
    }
}
