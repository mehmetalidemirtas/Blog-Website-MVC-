namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig17 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "NameSurname", c => c.String());
            AddColumn("dbo.Abouts", "ProfileImage", c => c.String());
            AddColumn("dbo.Abouts", "Job", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Abouts", "Job");
            DropColumn("dbo.Abouts", "ProfileImage");
            DropColumn("dbo.Abouts", "NameSurname");
        }
    }
}
