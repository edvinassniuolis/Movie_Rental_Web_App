namespace Movie_Renta_Web_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedDateTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Birthdate");
        }
    }
}
