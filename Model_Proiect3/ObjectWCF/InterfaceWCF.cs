using Model;
using System.Collections.Generic;
using System.ServiceModel;

namespace ObjectWCF
{
    [ServiceContract]
    interface InterfaceImages
    {
        [OperationContract]
        void saveImage(string Name, string Path, string About, string Place, string People);
        [OperationContract]
        void UpdateImage1(string Name, string Path, string About, string Place, string People);
        [OperationContract]
        void deleteImage(string Path);
        [OperationContract]
        List<PhotosVideos> getPhotos();
        [OperationContract]
        List<Place> getPlaces();
        [OperationContract]
        List<Person> getPerson();

    }

    [ServiceContract]
    interface IMplementInterface : InterfaceImages
    {
    }
}