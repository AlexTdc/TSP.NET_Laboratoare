using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API;
using Model;

namespace ObjectWCF
{
    public class Model : IMplementInterface
    {
        apiControlForm1 api1 = new apiControlForm1();
        apiControlForm2 api2 = new apiControlForm2();

        void InterfaceImages.deleteImage(string Path)
        {
            api2.deleteImage(Path);

        }


        void InterfaceImages.saveImage(string Name, string Path, string About, string Place, string People)
        {
            //apiControlForm1 api = new apiControlForm1();
            api1.saveImage(Name, Path, About, Place, People);
             
        }

        void InterfaceImages.UpdateImage1(string Name, string Path, string About, string Place, string People)
        {
            //apiControlForm2 api = new apiControlForm2();
            api2.UpdateImage1(Name, Path, About, Place, People);
        }

        List<PhotosVideos> InterfaceImages.getPhotos()
        {
            return api2.getPhotos();
            
        }

        List<Place> InterfaceImages.getPlaces()
        {
            return api2.getPlaces();

        }

        List<Person> InterfaceImages.getPerson()
        {
            return api2.getPerson();

        }
    }

}
