namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig22 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SubscribeMails", "MailSubs", c => c.String(maxLength: 50));
            DropColumn("dbo.SubscribeMails", "Mail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SubscribeMails", "Mail", c => c.String(maxLength: 50));
            DropColumn("dbo.SubscribeMails", "MailSubs");
        }
    }
}
