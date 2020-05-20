using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proj3.Models
{

    public partial class PhotosVideos
    {
        public PhotosVideos()
        {
            this.Person = new HashSet<Person>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<bool> CreateDate { get; set; }
        public string Path { get; set; }
        public string About { get; set; }
        public virtual Place Place { get; set; }
        public virtual ICollection<Person> Person { get; set; }
    }
}