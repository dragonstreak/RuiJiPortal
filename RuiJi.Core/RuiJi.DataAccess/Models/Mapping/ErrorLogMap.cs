using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RuiJi.DataAccess.Models.Mapping
{
    public class ErrorLogMap : EntityTypeConfiguration<ErrorLog>
    {
        public ErrorLogMap()
        {
            // Primary Key
            this.HasKey(t => t.ErrorId);

            // Properties
            this.Property(t => t.ErrorMessage)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.StackTrace)
                .HasMaxLength(4000);

            this.Property(t => t.ExceptionType)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ErrorLog");
            this.Property(t => t.ErrorId).HasColumnName("ErrorId");
            this.Property(t => t.ErrorMessage).HasColumnName("ErrorMessage");
            this.Property(t => t.StackTrace).HasColumnName("StackTrace");
            this.Property(t => t.ExceptionType).HasColumnName("ExceptionType");
            this.Property(t => t.InsertDate).HasColumnName("InsertDate");
            this.Property(t => t.InnerErrorId).HasColumnName("InnerErrorId");
        }
    }
}
