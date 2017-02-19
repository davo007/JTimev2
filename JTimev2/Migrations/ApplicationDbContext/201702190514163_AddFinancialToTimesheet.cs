namespace JTimev2.Migrations.ApplicationDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFinancialToTimesheet : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Timesheets", "TotalCost", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Timesheets", "TotalInvoices", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Timesheets", "AdjContract", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Timesheets", "AdjContract");
            DropColumn("dbo.Timesheets", "TotalInvoices");
            DropColumn("dbo.Timesheets", "TotalCost");
        }
    }
}
