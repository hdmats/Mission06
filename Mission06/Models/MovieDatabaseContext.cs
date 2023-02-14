using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06.Models
{
    public class MovieDatabaseContext : DbContext
    {
        public MovieDatabaseContext (DbContextOptions<MovieDatabaseContext> options): base (options)
        {

        }

        public DbSet<MoviesModel> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MoviesModel>().HasData(
               //seed data
                new MoviesModel
                {
                    ApplicationID = 1,
                    title = "UP",
                    category = "Action/Adventure",
                    year = 2009,
                    rating = "PG",
                    director = "Pete Docter",
                    edit = false,
                    lent = "Prof Hilton",
                    notes = "Section 3 is the Best!"
                },
                new MoviesModel
                {
                    ApplicationID = 2,
                    title = "A Quiet Place",
                    category = "Horrer/Suspense",
                    year = 2018,
                    rating = "PG-13",
                    director = "John Krasinski",
                    edit = false,
                    lent = null,
                    notes = null
                },
                new MoviesModel
                 {
                    ApplicationID = 3,
                    title = "Everything Everywhere All at Once",
                    category = "Comedy",
                    year = 2022,
                    rating = "R",
                    director = "Daniel Kwan",
                    edit = true,
                    lent = null,
                    notes = null
                 }
            );
        }
     }
}
