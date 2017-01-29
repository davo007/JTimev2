namespace JTimev2.Migrations.ApplicationDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedweekendingtoTimesheetModel : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TimesheetModels", newName: "Timesheets");
            CreateTable(
                "dbo.Weekendings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateOfSun = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Timesheets", "Description", c => c.String());
            AddColumn("dbo.Timesheets", "Posted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Timesheets", "WeekendingDate_Id", c => c.Int());
            CreateIndex("dbo.Timesheets", "WeekendingDate_Id");
            AddForeignKey("dbo.Timesheets", "WeekendingDate_Id", "dbo.Weekendings", "Id");
            DropColumn("dbo.Timesheets", "WeekendingDateId");
            DropColumn("dbo.Timesheets", "WeekendingDate");
            DropTable("dbo.WeekendingModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.WeekendingModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WeekendingDate = c.DateTime(nullable: false),
                        Description = c.String(),
                        Posted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Timesheets", "WeekendingDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Timesheets", "WeekendingDateId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Timesheets", "WeekendingDate_Id", "dbo.Weekendings");
            DropIndex("dbo.Timesheets", new[] { "WeekendingDate_Id" });
            DropColumn("dbo.Timesheets", "WeekendingDate_Id");
            DropColumn("dbo.Timesheets", "Posted");
            DropColumn("dbo.Timesheets", "Description");
            DropTable("dbo.Weekendings");
            RenameTable(name: "dbo.Timesheets", newName: "TimesheetModels");
        }
    }
}
