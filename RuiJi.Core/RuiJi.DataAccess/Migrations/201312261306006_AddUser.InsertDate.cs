namespace RuiJi.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserInsertDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SystemUser", "InsertDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SystemUser", "InsertDate");
        }
    }
}
