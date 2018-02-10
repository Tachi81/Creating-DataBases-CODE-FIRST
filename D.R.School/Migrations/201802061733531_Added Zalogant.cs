namespace D.R.School.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedZalogant : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Zalogant",
                c => new
                    {
                        ZalogantId = c.String(nullable: false, maxLength: 128),
                        Pesel = c.String(nullable: false, maxLength: 11),
                        DataZatrudnienia = c.DateTime(nullable: false),
                        Adres = c.String(nullable: false),
                        NrTelefonu = c.Int(nullable: false),
                        StanowiskoId_StanowiskoId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ZalogantId)
                .ForeignKey("dbo.Stanowisko", t => t.StanowiskoId_StanowiskoId, cascadeDelete: true)
                .Index(t => t.StanowiskoId_StanowiskoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Zalogant", "StanowiskoId_StanowiskoId", "dbo.Stanowisko");
            DropIndex("dbo.Zalogant", new[] { "StanowiskoId_StanowiskoId" });
            DropTable("dbo.Zalogant");
        }
    }
}
