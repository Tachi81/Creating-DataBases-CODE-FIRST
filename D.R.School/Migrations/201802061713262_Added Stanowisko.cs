namespace D.R.School.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedStanowisko : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stanowisko",
                c => new
                    {
                        StanowiskoId = c.String(nullable: false, maxLength: 128),
                        NazwaStanowiska = c.String(),
                    })
                .PrimaryKey(t => t.StanowiskoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Stanowisko");
        }
    }
}
