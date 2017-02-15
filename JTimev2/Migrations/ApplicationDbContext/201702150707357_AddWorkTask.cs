namespace JTimev2.Migrations.ApplicationDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWorkTask : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Timesheets", "WorkTask", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Timesheets", "WorkTask");
        }
    }
}
