using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalMovieApp
{
    public class Movie
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public int View { get; set; }


        // Poster
        public int ImageId { get; set; }
        public ImageModel Image { get; set; }
        // Video(trailer)

        //Many-to-many relationship - User

    }
}
