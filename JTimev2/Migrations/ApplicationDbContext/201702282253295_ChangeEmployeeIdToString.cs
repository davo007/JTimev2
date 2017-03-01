namespace JTimev2.Migrations.ApplicationDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeEmployeeIdToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Timesheets", "EmployeeId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Timesheets", "EmployeeId", c => c.Int(nullable: false));
        }
    }
}
