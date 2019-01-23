namespace Stock.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sales", "SalesTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Sales", "SatisZamani");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sales", "SatisZamani", c => c.DateTime(nullable: false));
            DropColumn("dbo.Sales", "SalesTime");
        }
    }
}
