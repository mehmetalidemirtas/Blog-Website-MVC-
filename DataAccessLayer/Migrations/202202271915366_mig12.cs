﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "Date");
        }
    }
}
