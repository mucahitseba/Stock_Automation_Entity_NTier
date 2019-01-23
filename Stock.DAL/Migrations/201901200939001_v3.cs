namespace Stock.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SaleDetails",
                c => new
                    {
                        SaleId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Piece = c.Int(nullable: false),
                        SalePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.SaleId, t.ProductId })
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Sales", t => t.SaleId, cascadeDelete: true)
                .Index(t => t.SaleId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        SaleId = c.Int(nullable: false, identity: true),
                        SatisZamani = c.DateTime(nullable: false),
                        PaymentMethod = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SaleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SaleDetails", "SaleId", "dbo.Sales");
            DropForeignKey("dbo.SaleDetails", "ProductId", "dbo.Products");
            DropIndex("dbo.SaleDetails", new[] { "ProductId" });
            DropIndex("dbo.SaleDetails", new[] { "SaleId" });
            DropTable("dbo.Sales");
            DropTable("dbo.SaleDetails");
        }
    }
}
