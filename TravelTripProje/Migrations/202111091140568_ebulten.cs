namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ebulten : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SubMails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SubEMail = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AlterColumn("dbo.Contacts", "AdSoyad", c => c.String(nullable: false, maxLength: 35));
            AlterColumn("dbo.Contacts", "Mail", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Contacts", "Mesaj", c => c.String(nullable: false, maxLength: 225));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "Mesaj", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Mail", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "AdSoyad", c => c.String(nullable: false));
            DropTable("dbo.SubMails");
        }
    }
}
