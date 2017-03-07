namespace JTimev2.Migrations.ApplicationDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [InteracctInitials], [FirstName], [LastName]) VALUES (N'a475c6c5-a877-4ffa-abdd-7be4a44e149b', N'admin@jwprince.com.au', 0, N'ALTGsov+VslM4010CBYT3WJhdDdahbgI7QuWeGwKDzcctQb/b3JeuUaBIxhZ4UPSiA==', N'09285909-0715-4201-8456-001bda22030c', NULL, 0, 0, NULL, 1, 0, N'admin@jwprince.com.au', N'admin', N'Admin', N'Istrator')
            
INSERT INTO[dbo].[AspNetRoles]([Id], [Name]) VALUES(N'0d63adfb-cbf9-4aac-a1b0-1f4c434ac5ff', N'IsAdmin')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a475c6c5-a877-4ffa-abdd-7be4a44e149b', N'0d63adfb-cbf9-4aac-a1b0-1f4c434ac5ff')
"
            );

        }
        
        public override void Down()
        {
        }
    }
}
