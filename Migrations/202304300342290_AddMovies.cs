namespace CineRent.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Hang Over 3',5, '2012-06-18', '2023-04-30',3)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Jumanji: The Next level',1, '2017-12-13', '2023-04-30',5)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Interstellar',2, '2014-11-07', '2023-04-30',6)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Inside Out',3, '2020-11-07', '2023-04-30',2)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Me Before You',4, '2018-11-07', '2023-04-30',6)");
        }

        public override void Down()
        {
        }
    }
}
