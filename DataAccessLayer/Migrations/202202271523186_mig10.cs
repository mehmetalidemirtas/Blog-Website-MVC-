﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "ContactStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "ContactStatus");
        }
    }
}
