using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalMovieApp
{
    class Initializer: DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            User user = new User()
            {
                Name = "Sahil",
                Surname = "Hashimli", 
                Username = "hashimlijr",
                Password = "sahil123"
            };
            context.Users.Add(user);
            

            Movie movie = new Movie()
            {
                MovieName = "Interstellar",
                Director = "Christopher Nolan",
                Description = "About everything",
                Genre = "Drama",
            };
            context.Movies.Add(movie);
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
