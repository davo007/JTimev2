namespace JTimev2.Migrations.ApplicationDbContext
{ 
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNullableTypesTimesheetsModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Timesheet", "NCR", c => c.Int());
            AlterColumn("dbo.Timesheet", "Variation", c => c.Int());
            AlterColumn("dbo.Timesheet", "MondayTime", c => c.Int());
            AlterColumn("dbo.Timesheet", "TuesdayTime", c => c.Int());
            AlterColumn("dbo.Timesheet", "WednesdayTime", c => c.Int());
            AlterColumn("dbo.Timesheet", "ThursdayTime", c => c.Int());
            AlterColumn("dbo.Timesheet", "FridayTime", c => c.Int());
            AlterColumn("dbo.Timesheet", "SaturadayTime", c => c.Int());
            AlterColumn("dbo.Timesheet", "SundayTime", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Timesheet", "SundayTime", c => c.Int(nullable: false));
            AlterColumn("dbo.Timesheet", "SaturadayTime", c => c.Int(nullable: false));
            AlterColumn("dbo.Timesheet", "FridayTime", c => c.Int(nullable: false));
            AlterColumn("dbo.Timesheet", "ThursdayTime", c => c.Int(nullable: false));
            AlterColumn("dbo.Timesheet", "WednesdayTime", c => c.Int(nullable: false));
            AlterColumn("dbo.Timesheet", "TuesdayTime", c => c.Int(nullable: false));
            AlterColumn("dbo.Timesheet", "MondayTime", c => c.Int(nullable: false));
            AlterColumn("dbo.Timesheet", "Variation", c => c.Int(nullable: false));
            AlterColumn("dbo.Timesheet", "NCR", c => c.Int(nullable: false));
        }
    }
}
