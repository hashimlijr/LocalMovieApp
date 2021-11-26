using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalMovieApp
{
    public class Context:DbContext
    {
        public Context(): base("MoviesDb")
        {
            Database.SetInitializer<Context>(new CreateDatabaseIfNotExists<Context>());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public DbSet<ImageModel> Images { get; set; }
    }
}
