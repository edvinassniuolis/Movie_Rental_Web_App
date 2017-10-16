namespace Movie_Renta_Web_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedREST : DbMigration
    {
        public override void Up()
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
        
        public override void Down()
        {
            DropTable("dbo.GenreDtoes");
        }
    }
}
