namespace Video_Rentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3c51df91-7a25-46c7-a539-70afcec91556', N'farid@gmail.com', 0, N'ALG0VOVE73HLLKp8c66nz1lqNNzHHJ7vIembgom8FGg2dSFuHFGK0E26TADOYIuC7Q==', N'380faad0-88d5-40fc-a112-8581ce647535', NULL, 0, 0, NULL, 1, 0, N'farid@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5db270fb-cce5-47d5-ba79-5e8748c2a750', N'admin@gmail.com', 0, N'AAPj9FRSnBUVsx2sZSSHerconhiUmvyV5yw/qDRDigbhH+bSg1sUDkZtlQ6bc6nUvw==', N'0694c913-a75e-4e8f-9cd7-1631958635e1', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'dd6c8786-2876-46d8-af87-9eb9b11920d3', N'guest@gmail.com', 0, N'AHdOGoyMpL+BxaH/GuuqOtal/meKXnmnbAYO/6VznrwKR8I4zfmT/raHRkAxEH/byQ==', N'04ad429a-78e8-4d51-939b-1f9cab73dabd', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'424d1f89-cc83-4f9e-ac53-babd94049eaa', N'CanManageMovies')


INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5db270fb-cce5-47d5-ba79-5e8748c2a750', N'424d1f89-cc83-4f9e-ac53-babd94049eaa')


");
        }
        
        public override void Down()
        {
        }
    }
}
