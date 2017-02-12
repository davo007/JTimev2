namespace JTimev2.Migrations.ApplicationDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDayHoursToDoubles : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Timesheets", "MondayTime", c => c.Double());
            AlterColumn("dbo.Timesheets", "TuesdayTime", c => c.Double());
            AlterColumn("dbo.Timesheets", "WednesdayTime", c => c.Double());
            AlterColumn("dbo.Timesheets", "ThursdayTime", c => c.Double());
            AlterColumn("dbo.Timesheets", "FridayTime", c => c.Double());
            AlterColumn("dbo.Timesheets", "SaturdayTime", c => c.Double());
            AlterColumn("dbo.Timesheets", "SundayTime", c => c.Double());
            AlterColumn("dbo.Timesheets", "Billable", c => c.Double(nullable: false));
            DropColumn("dbo.Timesheets", "Total");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Timesheets", "Total", c => c.Int(nullable: false));
            AlterColumn("dbo.Timesheets", "Billable", c => c.Int(nullable: false));
            AlterColumn("dbo.Timesheets", "SundayTime", c => c.Int());
            AlterColumn("dbo.Timesheets", "SaturdayTime", c => c.Int());
            AlterColumn("dbo.Timesheets", "FridayTime", c => c.Int());
            AlterColumn("dbo.Timesheets", "ThursdayTime", c => c.Int());
            AlterColumn("dbo.Timesheets", "WednesdayTime", c => c.Int());
            AlterColumn("dbo.Timesheets", "TuesdayTime", c => c.Int());
            AlterColumn("dbo.Timesheets", "MondayTime", c => c.Int());
        }
    }
}
