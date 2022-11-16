namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig16 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "ProfilePhotoURL", c => c.String(maxLength: 200));
            AddColumn("dbo.Addresses", "AddressURL", c => c.String());
            AlterColumn("dbo.Abouts", "AboutContent1", c => c.String());
            AlterColumn("dbo.Abouts", "AboutContent2", c => c.String());
            AlterColumn("dbo.Abouts", "AboutImage1", c => c.String(maxLength: 200));
            AlterColumn("dbo.Authors", "AuthorImage", c => c.String(maxLength: 200));
            AlterColumn("dbo.Authors", "AuthorAbout", c => c.String(maxLength: 500));
            DropColumn("dbo.Abouts", "AboutImage2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Abouts", "AboutImage2", c => c.String(maxLength: 100));
            AlterColumn("dbo.Authors", "AuthorAbout", c => c.String(maxLength: 250));
            AlterColumn("dbo.Authors", "AuthorImage", c => c.String(maxLength: 100));
            AlterColumn("dbo.Abouts", "AboutImage1", c => c.String(maxLength: 100));
            AlterColumn("dbo.Abouts", "AboutContent2", c => c.String(maxLength: 500));
            AlterColumn("dbo.Abouts", "AboutContent1", c => c.String(maxLength: 500));
            DropColumn("dbo.Addresses", "AddressURL");
            DropColumn("dbo.Abouts", "ProfilePhotoURL");
        }
    }
}
