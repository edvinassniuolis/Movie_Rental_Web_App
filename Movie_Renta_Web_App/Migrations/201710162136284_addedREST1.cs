namespace Movie_Renta_Web_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedREST1 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.GenreDtoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.GenreDtoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
