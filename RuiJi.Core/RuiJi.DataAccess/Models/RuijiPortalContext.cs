using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using RuiJi.DataAccess.Models.Mapping;

namespace RuiJi.DataAccess.Models
{
    public partial class RuijiPortalContext : DbContext
    {
        static RuijiPortalContext()
        {
            Database.SetInitializer<RuijiPortalContext>(null);
        }

        public RuijiPortalContext()
            : base("Name=RuijiPortalContext")
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleType_Lkp> ArticleType_Lkp { get; set; }
        public DbSet<SystemUser> SystemUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ArticleMap());
            modelBuilder.Configurations.Add(new ArticleType_LkpMap());
            modelBuilder.Configurations.Add(new SystemUserMap());
			CustomModelCreating(modelBuilder);
        }
    }
}