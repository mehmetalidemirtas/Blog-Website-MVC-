namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig20 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "Mail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Authors", "Mail");
        }
    }
}
