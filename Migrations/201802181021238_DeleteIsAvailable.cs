namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteIsAvailable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "IsAvailable");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "IsAvailable", c => c.Boolean(nullable: false));
        }
    }
}
