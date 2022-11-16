namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig18 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "BlogImage2", c => c.String());
            AddColumn("dbo.Blogs", "BlogImage3", c => c.String());
            AddColumn("dbo.Blogs", "BlogImage4", c => c.String());
            AddColumn("dbo.Blogs", "BlogImage5", c => c.String());
            AddColumn("dbo.Blogs", "BlogContent2", c => c.String());
            AddColumn("dbo.Blogs", "BlogContent3", c => c.String());
            AddColumn("dbo.Blogs", "BlogContent4", c => c.String());
            AddColumn("dbo.Blogs", "BlogContent5", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "BlogContent5");
            DropColumn("dbo.Blogs", "BlogContent4");
            DropColumn("dbo.Blogs", "BlogContent3");
            DropColumn("dbo.Blogs", "BlogContent2");
            DropColumn("dbo.Blogs", "BlogImage5");
            DropColumn("dbo.Blogs", "BlogImage4");
            DropColumn("dbo.Blogs", "BlogImage3");
            DropColumn("dbo.Blogs", "BlogImage2");
        }
    }
}
