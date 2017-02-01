namespace JTimev2.Migrations.ApplicationDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedSaturdaySpelling : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Timesheets", "SaturdayTime", c => c.Int());
            DropColumn("dbo.Timesheets", "SaturadayTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Timesheets", "SaturadayTime", c => c.Int());
            DropColumn("dbo.Timesheets", "SaturdayTime");
        }
    }
}
