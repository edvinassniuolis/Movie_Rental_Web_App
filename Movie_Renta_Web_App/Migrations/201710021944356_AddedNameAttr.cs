namespace Movie_Renta_Web_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNameAttr : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String());
        }
    }
}
