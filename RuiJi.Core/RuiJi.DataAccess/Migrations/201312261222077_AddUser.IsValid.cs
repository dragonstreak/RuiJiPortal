namespace RuiJi.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserIsValid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SystemUser", "IsValid", c => c.Boolean(false, true));            
        }
        
        public override void Down()
        {
            DropColumn("dbo.System.User", "IsValid");
        }
    }
}
