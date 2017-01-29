namespace JTimev2.Migrations.ApplicationDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWeekendings : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Weekending",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WeekendingDate = c.DateTime(nullable: false),
                        Description = c.String(),
                        Posted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Weekending");
        }
    }
}
