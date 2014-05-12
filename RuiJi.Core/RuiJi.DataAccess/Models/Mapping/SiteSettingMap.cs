using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RuiJi.DataAccess.Models.Mapping
{
    public class SiteSettingMap : EntityTypeConfiguration<SiteSetting>
    {
        public SiteSettingMap()
        {
            // Primary Key
            this.HasKey(t => t.SiteSettingId);

            // Properties
            this.Property(t => t.MasterCSSFile)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("SiteSetting");
            this.Property(t => t.SiteSettingId).HasColumnName("SiteSettingId");
            this.Property(t => t.MasterCSSFile).HasColumnName("MasterCSSFile");
            this.Property(t => t.CSSVersion).HasColumnName("CSSVersion");
        }
    }
}
