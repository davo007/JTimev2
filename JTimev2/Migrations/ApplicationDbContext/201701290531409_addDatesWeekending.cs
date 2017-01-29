namespace JTimev2.Migrations.ApplicationDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDatesWeekending : DbMigration
    {
        public override void Up()
        {
            DateTime startDate;
            DateTime newDate;
            DateTime.TryParse("2017/01/22", out startDate);

            for (int i = 0; i < 52; i++)
            {
                newDate = startDate.AddDays(7 * i);

                Sql("INSERT INTO[dbo].[Weekendings] ([DateOfSun]) VALUES(N'" + newDate.Year.ToString() + "-" + newDate.Month.ToString() + "-" + newDate.Day.ToString() + " 00:00:00')");
            }
        }
        
        public override void Down()
        {
        }
    }
}
