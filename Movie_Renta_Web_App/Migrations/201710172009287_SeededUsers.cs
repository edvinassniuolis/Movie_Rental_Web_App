namespace Movie_Renta_Web_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeededUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'82e7abec-3150-462b-9176-d35bf4d243d2', N'guest@vidly.com', 0, N'AMO5VR0ln/xwAkPCfUSKak2auwzrdZ6+zTHeysf1idABvZ7jj1CpA6h1DwVVIgTSgw==', N'4e65eec1-ea88-4100-b27f-818727b15760', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e7be858f-5527-4502-b49b-b031a7332949', N'admin@vidly.com', 0, N'ANrnGJPoiwEMr8mxLq+p5lmDvtLiIdvOJQBoUBU4BE7BCoB8ekAqHti/E4h+k7mQLg==', N'4cf40d77-9ff4-4bfe-8f9c-0e55c26c78ec', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'864c93a9-ff67-4fce-903b-30cef81b2b46', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e7be858f-5527-4502-b49b-b031a7332949', N'864c93a9-ff67-4fce-903b-30cef81b2b46')
");
        }
        
        public override void Down()
        {
        }
    }
}
