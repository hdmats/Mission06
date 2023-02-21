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

        public DbSet<MoviesModel> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { categoryID = 1, categoryname = "Action/Adventure" },
                new Category { categoryID = 2, categoryname = "Comedy" },
                new Category { categoryID = 3, categoryname = "Drama" },
                new Category { categoryID = 4, categoryname = "Family" },
                new Category { categoryID = 5, categoryname = "Horror/Suspense" },
                new Category { categoryID = 6, categoryname = "Miscellaneous" },
                new Category { categoryID = 7, categoryname = "Television" },
                new Category { categoryID = 8, categoryname = "VHS" }
            );
            mb.Entity<MoviesModel>().HasData(
               //seed data
                new MoviesModel
                {
                    ApplicationID = 1,
                    title = "UP",
                    categoryID = 4,
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
                    categoryID = 5,
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
                    categoryID = 1,
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
