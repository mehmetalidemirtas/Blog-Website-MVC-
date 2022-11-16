namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig19 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Authors", "AuthorImage");
            DropColumn("dbo.Authors", "AuthorAbout");
            DropColumn("dbo.Authors", "Mail");
            DropColumn("dbo.Authors", "Password");
            DropColumn("dbo.Authors", "Phone");
            DropColumn("dbo.Authors", "GithubLink");
            DropColumn("dbo.Authors", "LinkedinLink");
            DropColumn("dbo.Authors", "TwitterLink");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Authors", "TwitterLink", c => c.String());
            AddColumn("dbo.Authors", "LinkedinLink", c => c.String());
            AddColumn("dbo.Authors", "GithubLink", c => c.String());
            AddColumn("dbo.Authors", "Phone", c => c.String(maxLength: 20));
            AddColumn("dbo.Authors", "Password", c => c.String(maxLength: 50));
            AddColumn("dbo.Authors", "Mail", c => c.String(maxLength: 50));
            AddColumn("dbo.Authors", "AuthorAbout", c => c.String(maxLength: 500));
            AddColumn("dbo.Authors", "AuthorImage", c => c.String(maxLength: 200));
        }
    }
}
