namespace JTimev2.Migrations.ApplicationDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWeekendingId : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Timesheets", name: "WeekendingDate_Id", newName: "Weekending_Id");
            RenameIndex(table: "dbo.Timesheets", name: "IX_WeekendingDate_Id", newName: "IX_Weekending_Id");
            AddColumn("dbo.Timesheets", "WeekendingId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Timesheets", "WeekendingId");
            RenameIndex(table: "dbo.Timesheets", name: "IX_Weekending_Id", newName: "IX_WeekendingDate_Id");
            RenameColumn(table: "dbo.Timesheets", name: "Weekending_Id", newName: "WeekendingDate_Id");
        }
    }
}
