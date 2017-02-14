namespace JTimev2.Migrations.ApplicationDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeNCRtoString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Timesheets", "NCR", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Timesheets", "NCR", c => c.Int());
        }
    }
}
