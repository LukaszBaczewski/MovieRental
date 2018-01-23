namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'139fa97d-7197-4610-973d-edd2700ffb84', N'admin@vidly.com', 0, N'AAd8iER+5P0XQgnMUz/2wfcuEoMxLBpGKBIMFntCIvX1hsa/Wc/VIqJ8x2NuTL3E7Q==', N'37886365-7327-4d35-9fde-6d928321a76b', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7a8f92fd-f62f-490a-b12e-4b64a8b61bdf', N'guest@vidly.com', 0, N'ACKdFGf2ilihcRXOzwzWvZwdfYlHSxSHTdXd7QC4oxmwquYxmwWVr9NdJUcerc27WQ==', N'61ce78bd-65b9-487c-99bc-00d2758861a7', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'697aa6b1-67cf-4853-8e95-999e530510c8', N'CanManageMovies')

INSERT INTO[dbo].[AspNetUserRoles]([UserId], [RoleId]) VALUES(N'139fa97d-7197-4610-973d-edd2700ffb84', N'697aa6b1-67cf-4853-8e95-999e530510c8')

");
        }
        
        public override void Down()
        {
        }
    }
}
