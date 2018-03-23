namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAgeRatingToMovies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "AgeRating", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "AgeRating");
        }
    }
}
