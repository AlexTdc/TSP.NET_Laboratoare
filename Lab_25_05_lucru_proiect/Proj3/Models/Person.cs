using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proj3.Models
{


    public partial class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhotosVideosId { get; set; }
        public virtual PhotosVideos PhotosVideos { get; set; }
    }
}