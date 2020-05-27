using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project3.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    [DataContract(IsReference = true)]

    public partial class PhotosVideosDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhotosVideosDTO()
        {
            this.Person = new HashSet<PersonDTO>();
        }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public Nullable<bool> CreateDate { get; set; }
        [DataMember]
        public string Path { get; set; }
        [DataMember]
        public string About { get; set; }
        [DataMember]
        public virtual PlaceDTO Place { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual ICollection<PersonDTO> Person { get; set; }
    }
}
