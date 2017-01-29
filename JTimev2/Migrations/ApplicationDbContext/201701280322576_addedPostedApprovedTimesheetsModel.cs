namespace JTimev2.Migrations.ApplicationDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedPostedApprovedTimesheetsModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Timesheet", "Posted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Timesheet", "Approved", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Timesheet", "Approved");
            DropColumn("dbo.Timesheet", "Posted");
        }
    }
}
