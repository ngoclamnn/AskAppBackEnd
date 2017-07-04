namespace AskAppBackEnd.WebServiceAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        RoleId = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.RoleId);
            
            CreateTable(
                "dbo.UserRole",
                c => new
                    {
                        UserId = c.Guid(nullable: false),
                        RoleId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.Role", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);

            //CreateTable(
            //    "dbo.Users",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            Email = c.String(),
            //            EmailConfirmed = c.Boolean(nullable: false),
            //            PasswordHash = c.String(),
            //            SecurityStamp = c.String(),
            //            PhoneNumber = c.String(),
            //            PhoneNumberConfirmed = c.Boolean(nullable: false),
            //            TwoFactorEnabled = c.Boolean(nullable: false),
            //            LockoutEndDateUtc = c.DateTime(),
            //            LockoutEnabled = c.Boolean(nullable: false),
            //            AccessFailedCount = c.Int(nullable: false),
            //            UserName = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id);

            AddColumn("dbo.Users", "EmailConfirmed", c => c.String(maxLength: 200));
            AddColumn("dbo.Users", "PasswordHash", c => c.String(maxLength: 200));
            AddColumn("dbo.Users", "SecurityStamp", c => c.String(maxLength: 200));
            AddColumn("dbo.Users", "FacebookAccount", c => c.String(maxLength: 200));
            AddColumn("dbo.Users", "DOB", c => c.DateTime());
            AddColumn("dbo.Users", "Gender", c => c.String(maxLength: 50));
            AddColumn("dbo.Users", "Nationality", c => c.String(maxLength: 200));
            AddColumn("dbo.Users", "Interests", c => c.String(maxLength: 2000));
            AddColumn("dbo.Users", "IsVisible", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "IsNotified", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "DisplayUserProfile", c => c.Boolean());
            AddColumn("dbo.Users", "AboutMe", c => c.String(maxLength: 250));
            AddColumn("dbo.Users", "ProfilePicture", c => c.String());
            AddColumn("dbo.Users", "DeviceId", c => c.String(maxLength: 200));
            AddColumn("dbo.Users", "Status", c => c.String(maxLength: 50));
            AddColumn("dbo.Users", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "LastEditDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "CreationDate", c => c.DateTime(nullable: false));

            CreateTable(
                "dbo.UserClaim",
                c => new
                    {
                        UserClaimId = c.Int(nullable: false, identity: true),
                        UserId = c.Guid(nullable: false),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.UserClaimId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UserLogin",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRole", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserLogin", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserClaim", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserRole", "RoleId", "dbo.Role");
            DropIndex("dbo.UserLogin", new[] { "UserId" });
            DropIndex("dbo.UserClaim", new[] { "UserId" });
            DropIndex("dbo.UserRole", new[] { "RoleId" });
            DropIndex("dbo.UserRole", new[] { "UserId" });
            DropTable("dbo.UserLogin");
            DropTable("dbo.UserClaim");
            DropTable("dbo.Users");
            DropTable("dbo.UserRole");
            DropTable("dbo.Role");
        }
    }
}
