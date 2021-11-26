using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalMovieApp
{
    public class ImageModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageFormat { get; set; }
        public byte[] Data { get; set; }
    }
}
