﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SubscribeMails",
                c => new
                    {
                        MailID = c.Int(nullable: false, identity: true),
                        Mail = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MailID);
            
            AlterColumn("dbo.Blogs", "BlogImage", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Blogs", "BlogImage", c => c.String(maxLength: 100));
            DropTable("dbo.SubscribeMails");
        }
    }
}
