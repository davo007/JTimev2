namespace JTimev2.Migrations.ApplicationDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixWeekendingId2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Timesheets", "WeekendingId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Timesheets", "WeekendingId");
        }
    }
}
