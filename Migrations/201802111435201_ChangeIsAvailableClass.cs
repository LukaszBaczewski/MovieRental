namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeIsAvailableClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "IsAvailable", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "IsAvailable");
        }
    }
}
