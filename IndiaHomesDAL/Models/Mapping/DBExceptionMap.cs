using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace IndiaHomesDAL.Models.Mapping
{
    public class DBExceptionMap : EntityTypeConfiguration<DBException>
    {
        public DBExceptionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SessionId, t.SourceProcedure, t.Timestamp });

            // Properties
            this.Property(t => t.SessionId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SourceProcedure)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LineNo)
                .HasMaxLength(50);

            this.Property(t => t.ErrorNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DBException");
            this.Property(t => t.SessionId).HasColumnName("SessionId");
            this.Property(t => t.SourceProcedure).HasColumnName("SourceProcedure");
            this.Property(t => t.LineNo).HasColumnName("LineNo");
            this.Property(t => t.Message).HasColumnName("Message");
            this.Property(t => t.ErrorNo).HasColumnName("ErrorNo");
            this.Property(t => t.Timestamp).HasColumnName("Timestamp");
        }
    }
}
