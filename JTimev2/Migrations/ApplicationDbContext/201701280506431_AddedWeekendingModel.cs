namespace JTimev2.Migrations.ApplicationDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedWeekendingModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Timesheet", "WeekendingDateId", c => c.Int(nullable: false));
            DropColumn("dbo.Timesheet", "Posted");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Timesheet", "Posted", c => c.Boolean(nullable: false));
            DropColumn("dbo.Timesheet", "WeekendingDateId");
        }
    }
}
