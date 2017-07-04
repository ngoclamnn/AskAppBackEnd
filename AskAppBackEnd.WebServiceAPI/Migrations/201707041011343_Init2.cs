namespace AskAppBackEnd.WebServiceAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Password", c => c.String(maxLength: 200));
            AddColumn("dbo.Users", "Firstname", c => c.String(maxLength: 200));
            AddColumn("dbo.Users", "Lastname", c => c.String(maxLength: 200));
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
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "CreationDate");
            DropColumn("dbo.Users", "LastEditDate");
            DropColumn("dbo.Users", "IsDeleted");
            DropColumn("dbo.Users", "Status");
            DropColumn("dbo.Users", "DeviceId");
            DropColumn("dbo.Users", "ProfilePicture");
            DropColumn("dbo.Users", "AboutMe");
            DropColumn("dbo.Users", "DisplayUserProfile");
            DropColumn("dbo.Users", "IsNotified");
            DropColumn("dbo.Users", "IsVisible");
            DropColumn("dbo.Users", "Interests");
            DropColumn("dbo.Users", "Nationality");
            DropColumn("dbo.Users", "Gender");
            DropColumn("dbo.Users", "DOB");
            DropColumn("dbo.Users", "FacebookAccount");
            DropColumn("dbo.Users", "Lastname");
            DropColumn("dbo.Users", "Firstname");
            DropColumn("dbo.Users", "Password");
        }
    }
}
