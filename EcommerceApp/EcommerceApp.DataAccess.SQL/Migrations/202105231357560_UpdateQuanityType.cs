namespace EcommerceApp.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateQuanityType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BasketItems", "Quanity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BasketItems", "Quanity", c => c.String());
        }
    }
}
