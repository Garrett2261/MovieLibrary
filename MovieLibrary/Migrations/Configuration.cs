namespace MovieLibrary.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MovieLibrary.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MovieLibrary.Models.MovieLibraryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MovieLibrary.Models.MovieLibraryContext context)
        {
            context.Movies.AddOrUpdate(x => x.MovieId,
                new Movie() { MovieId = 1, Title = "The Departed", Genre = "Drama", Director = "Martin Scorsese" },
                new Movie() { MovieId = 2, Title = "The Dark Knight", Genre = "Drama", Director = "Christopher Nolan" },
                new Movie() { MovieId = 3, Title = "Inception", Genre = "Drama", Director = "Christopher Nolan" },
                new Movie() { MovieId = 4, Title = "Pineapple Express", Genre = "Comedy", Director = "David Gordon Green" },
                new Movie() { MovieId = 5, Title = "Die Hard", Genre = "Action", Director = "John McTiernan" }
                );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
