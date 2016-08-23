using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace IndiaHomesDAL.Models.Mapping
{
    public class AccountMap : EntityTypeConfiguration<Account>
    {
        public AccountMap()
        {
            // Primary Key
            this.HasKey(t => t.Username);

            // Properties
            this.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Username)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EmailId)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Account");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.Username).HasColumnName("Username");
            this.Property(t => t.LockedStatus).HasColumnName("LockedStatus");
            this.Property(t => t.EmailId).HasColumnName("EmailId");
            this.Property(t => t.NoOfAttempts).HasColumnName("NoOfAttempts");
            this.Property(t => t.LockedTime).HasColumnName("LockedTime");
            this.Property(t => t.LastFailedLogin).HasColumnName("LastFailedLogin");
        }
    }
}
