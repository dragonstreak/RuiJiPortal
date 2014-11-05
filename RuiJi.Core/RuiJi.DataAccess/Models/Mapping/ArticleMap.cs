using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RuiJi.DataAccess.Models.Mapping
{
    public class ArticleMap : EntityTypeConfiguration<Article>
    {
        public ArticleMap()
        {
            // Primary Key
            this.HasKey(t => t.ArticleId);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Summary)
                .HasMaxLength(1000);

            this.Property(t => t.ContentDetail)
                .IsRequired();

            this.Property(t => t.Author)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UpdateBy)
                .HasMaxLength(50);

            this.Property(t => t.InsertBy)
                .HasMaxLength(50);

            this.Property(t => t.TIMESTAMP)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            this.Property(t => t.DisplayOrder)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Article");
            this.Property(t => t.ArticleId).HasColumnName("ArticleId");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Summary).HasColumnName("Summary");
            this.Property(t => t.ContentDetail).HasColumnName("ContentDetail");
            this.Property(t => t.ArticleCategoryId).HasColumnName("ArticleCategoryId");
            this.Property(t => t.Author).HasColumnName("Author");
            this.Property(t => t.IsPublished).HasColumnName("IsPublished");
            this.Property(t => t.PublishDate).HasColumnName("PublishDate");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
            this.Property(t => t.UpdateBy).HasColumnName("UpdateBy");
            this.Property(t => t.InsertDate).HasColumnName("InsertDate");
            this.Property(t => t.InsertBy).HasColumnName("InsertBy");
            this.Property(t => t.TIMESTAMP).HasColumnName("TIMESTAMP");
            this.Property(t => t.LanguageType).HasColumnName("LanguageType");
            this.Property(t => t.DisplayOrder).HasColumnName("DisplayOrder");
        }
    }
}
