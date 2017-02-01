namespace JTimev2.Migrations.ApplicationDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixWeekendingId : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Timesheets", "WeekendingId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Timesheets", "WeekendingId", c => c.Byte(nullable: false));
        }
    }
}
