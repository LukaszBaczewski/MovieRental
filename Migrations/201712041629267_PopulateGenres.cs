namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Name) VALUES ('Action')");
            Sql("INSERT INTO Genres(Name) VALUES ('Comedy')");
            Sql("INSERT INTO Genres(Name) VALUES ('Horror')");
            Sql("INSERT INTO Genres(Name) VALUES ('Thriller')");
            Sql("INSERT INTO Genres(Name) VALUES ('Sci-fi')");
            Sql("INSERT INTO Genres(Name) VALUES ('Fantasy')");
            Sql("INSERT INTO Genres(Name) VALUES ('Romantic Comedy')");
            Sql("INSERT INTO Genres(Name) VALUES ('Animation')");
            Sql("INSERT INTO Genres(Name) VALUES ('Documentary')");
            Sql("INSERT INTO Genres(Name) VALUES ('Family')");
            Sql("INSERT INTO Genres(Name) VALUES ('Sport')");
            Sql("INSERT INTO Genres(Name) VALUES ('War')");
            Sql("INSERT INTO Genres(Name) VALUES ('Drama')");
            Sql("INSERT INTO Genres(Name) VALUES ('Biography')");
            Sql("INSERT INTO Genres(Name) VALUES ('Western')");
            Sql("INSERT INTO Genres(Name) VALUES ('Music')");
        }
        
        public override void Down()
        {
        }
    }
}
