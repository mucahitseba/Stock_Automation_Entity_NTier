namespace Stock.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sales", "SaleTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Sales", "SalesTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sales", "SalesTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Sales", "SaleTime");
        }
    }
}
