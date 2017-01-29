namespace JTimev2.Migrations.ApplicationDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReaddTimesheetDataModel1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Timesheet",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        WeekEndingDate = c.DateTime(nullable: false),
                        JobNumber = c.Int(nullable: false),
                        Package = c.String(),
                        Activity = c.String(),
                        NCR = c.Int(nullable: false),
                        Variation = c.Int(nullable: false),
                        MondayTime = c.Int(nullable: false),
                        TuesdayTime = c.Int(nullable: false),
                        WednesdayTime = c.Int(nullable: false),
                        ThursdayTime = c.Int(nullable: false),
                        FridayTime = c.Int(nullable: false),
                        SaturadayTime = c.Int(nullable: false),
                        SundayTime = c.Int(nullable: false),
                        Total = c.Int(nullable: false),
                        Billable = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Timesheet");
        }
    }
}
