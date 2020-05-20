using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proj3.Models
{
    public partial class Place
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual PhotosVideos PhotosVideos { get; set; }
    }
}

