namespace JTimev2.Migrations.ApplicationDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addtotal : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Timesheets", "Total");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Timesheets", "Total", c => c.Double(nullable: false));
        }
    }
}
