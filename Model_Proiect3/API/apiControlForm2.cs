using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.IO;
using System.Data.Entity.Migrations;
using System.Runtime.InteropServices;
using System.Threading;
using System.Linq.Expressions;


namespace API
{
    public partial class apiControlForm2
    {
        public void UpdateImage1(string Name, string Path, string About, string Place, string People)
        {
            using (var db = new Model1Container())
            {
                int id = 0;
                PhotosVideos pv = new PhotosVideos()
                {
                    Id = id,
                    Name = Name,
                    CreateDate = true,
                    Path = Path,
                    About = About
                };

                var result = db.PhotosVideosSet.SingleOrDefault(p => p.Path == Path);
                var searchPath = pv.Path ;
                var searchId = db.PhotosVideosSet.FirstOrDefault(f => f.Path == searchPath).Id;
                
                if (result != null)
                {

                    result.Path = Path;
                    result.Name = Name;
                    result.About = About;
                    db.SaveChanges();

                }

                Place plc = new Place()
                {
                    Name = Place
                };

                var res = db.PlaceSet.SingleOrDefault(pl => pl.Id==searchId);

                if (res != null)
                {
                    res.Name = Place;
                    db.SaveChanges();
                }

                string[] pplList = People.Split(',');
                int sizeOfList = pplList.Length;

                for (var index = 0; index < pplList.Length; index++)
                {
                    var t = pplList[index];
                    Person person = new Person()
                    {
                        Name = t.Trim(' '),
                        PhotosVideosId = searchId
                    };
                    var rsl = db.PersonSet.SingleOrDefault(pr => pr.PhotosVideosId == searchId);

                    if (sizeOfList == 1 || index==0)
                    {
                        // var rsl = db.PersonSet.SingleOrDefault(pr => pr.PhotosVideosId == searchId);

                        if (rsl != null)
                        {
                            rsl.Name = People;
                        }

                        db.SaveChanges();
                    }
                    else if (sizeOfList > 1)
                    {
                        db.PersonSet.Add(person);
                        db.SaveChanges();
                    }
                }
            }

        }

        public void deleteImage(string Path)
        {
            using (var db = new Model1Container())
            {
                PhotosVideos del = new PhotosVideos()
                {
                    Path = Path,
                    CreateDate = false
                };
                var search = db.PhotosVideosSet.SingleOrDefault(p => p.Path == Path);
                if (search != null)
                {
                    search.Path = null;
                }
                db.SaveChanges();

            }
        }

        public List<PhotosVideos> getPhotos()
        {
            using (var db = new Model1Container())
            {
                var r = db.PhotosVideosSet.ToList();

                return r;
            }

        }

        public List<Place> getPlaces()
        {
            using (var db = new Model1Container())
            {
                var q = db.PlaceSet.ToList();

                return q;
            }

        }

        public List<Person> getPerson()
        {
            using (var db = new Model1Container())
            {
                var s = db.PersonSet.ToList();

                return s;
            }

        }
    }
}

