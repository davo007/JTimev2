namespace JTimev2.Migrations.ApplicationDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Minortimesheetchange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Timesheets", "Total", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Timesheets", "Total");
        }
    }
}
