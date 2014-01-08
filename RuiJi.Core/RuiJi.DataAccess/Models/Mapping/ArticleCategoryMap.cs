using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RuiJi.DataAccess.Models.Mapping
{
    public class ArticleCategoryMap : EntityTypeConfiguration<ArticleCategory>
    {
        public ArticleCategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.ArticleCategoryId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UIResourceKey)
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            this.Property(t => t.CreateBy)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UpdateBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ArticleCategory");
            this.Property(t => t.ArticleCategoryId).HasColumnName("ArticleCategoryId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.UIResourceKey).HasColumnName("UIResourceKey");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.ParentCategoryId).HasColumnName("ParentCategoryId");
            this.Property(t => t.IsShowOnHomePage).HasColumnName("IsShowOnHomePage");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.CreateBy).HasColumnName("CreateBy");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
            this.Property(t => t.UpdateBy).HasColumnName("UpdateBy");
            this.Property(t => t.HomePageDisplayOrder).HasColumnName("HomePageDisplayOrder");
        }
    }
}
