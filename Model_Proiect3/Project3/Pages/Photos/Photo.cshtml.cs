using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferenceP3;

namespace Project3.Pages.Photos
{
    public class PhotoModel : PageModel
    {
        public MplementInterfaceClient api3 = new MplementInterfaceClient();
        public List<PhotosVideos> pht = new List<PhotosVideos>();
        public List<string> b64 { get; set; }
        public async Task OnGetAsync()
        {
            byte[] imageArray;
            string base64ImageRepresentation;
            pht = await api3.getPhotosAsync();
            b64 = new List<string>();
            for (var i = 0; i < pht.Count; i++)
            {
                imageArray = System.IO.File.ReadAllBytes(pht[i].Path);

                base64ImageRepresentation = Convert.ToBase64String(imageArray);
                b64.Add("data:image/jpg" + ";base64," + base64ImageRepresentation);
            }
       


        }
    }
}