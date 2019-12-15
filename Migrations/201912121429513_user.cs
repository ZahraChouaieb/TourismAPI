namespace APITourismApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lieux",
                c => new
                    {
                        lieuId = c.Int(nullable: false, identity: true),
                        nameLieu = c.String(nullable: false, maxLength: 128),
                        ville = c.String(nullable: false, maxLength: 128),
                        zoneGeo = c.String(nullable: false, maxLength: 256),
                        temperatureZone = c.String(nullable: false, maxLength: 256),
                        image = c.String(nullable: false, maxLength: 256),
                        description = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.lieuId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 128),
                        Email = c.String(nullable: false, maxLength: 256),
                        Password = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Lieux");
        }
    }
}
