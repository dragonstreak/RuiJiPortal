using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RuiJi.DataAccess.Models.Mapping
{
    public class UserRole_lnkMap : EntityTypeConfiguration<UserRole_lnk>
    {
        public UserRole_lnkMap()
        {
            // Primary Key
            this.HasKey(t => t.UserRoleId);

            // Properties
            // Table & Column Mappings
            this.ToTable("UserRole_lnk");
            this.Property(t => t.UserRoleId).HasColumnName("UserRoleId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.RoleId).HasColumnName("RoleId");

            // Relationships
            this.HasRequired(t => t.Role)
                .WithMany(t => t.UserRole_lnk)
                .HasForeignKey(d => d.RoleId);
            this.HasRequired(t => t.SystemUser)
                .WithMany(t => t.UserRole_lnk)
                .HasForeignKey(d => d.UserId);

        }
    }
}
