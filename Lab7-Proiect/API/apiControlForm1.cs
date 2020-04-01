using Model;
using System.Data.Entity.Migrations;

namespace API
{
    public class apiControlForm1
    {
        public void saveImage(string Name, string Path, string About, string Place, string People)
        {
            using (var db = new Model1Container())
            {
                PhotosVideos photovideo = new PhotosVideos()
                {
                    Name = Name,
                    CreateDate = true,
                    Path = Path,
                    About = About
                };

                Place place = new Place()
                {
                    Name = Place,
                    PhotosVideos = photovideo
                };
                
                db.PhotosVideosSet.Add(photovideo);
                db.PlaceSet.Add(place);

                string[] peopleList = People.Split(',');
                
                foreach (var t in peopleList)
                {
                    Person person = new Person()
                    {
                        Name = t.Trim(' '),
                        PhotosVideos = photovideo
                    };
                    db.PersonSet.Add(person);
                }

                db.SaveChanges();
                
                /*try
                {

                    context.SaveChanges();
                }
                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    throw;
                }*/
            }
            
        }
    }
}
