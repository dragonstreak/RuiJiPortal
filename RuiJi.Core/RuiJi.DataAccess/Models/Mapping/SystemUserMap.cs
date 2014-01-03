using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RuiJi.DataAccess.Models.Mapping
{
    public class SystemUserMap : EntityTypeConfiguration<SystemUser>
    {
        public SystemUserMap()
        {
            // Primary Key
            this.HasKey(t => t.UserId);

            // Properties
            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SystemUser");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.IsValid).HasColumnName("IsValid");
            this.Property(t => t.InsertDate).HasColumnName("InsertDate");
        }
    }
}
