namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig21 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Admins", "Username", c => c.String());
            AlterColumn("dbo.Admins", "Password", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Admins", "Password", c => c.String(maxLength: 20));
            AlterColumn("dbo.Admins", "Username", c => c.String(maxLength: 20));
        }
    }
}
