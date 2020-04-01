using System.Collections.Generic;
using System.ServiceModel;
using API;
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

    }

    [ServiceContract]
    interface IPostComment : InterfaceImages
    {
    }
}