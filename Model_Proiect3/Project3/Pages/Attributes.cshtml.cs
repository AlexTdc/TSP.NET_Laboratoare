﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferenceP3;

namespace Project3.Pages
{
    public class AttributesModel : PageModel
    {
        public MplementInterfaceClient api3 = new MplementInterfaceClient();
        public List<Place> plc = new List<Place>();
        public List<Person> prs = new List<Person>();
        public List<PhotosVideos> getAllPht = new List<PhotosVideos>();
        public List<PhotosVideos> displayPht = new List<PhotosVideos>();
        public List<string> b64 { get; set; }
        public async Task OnGetAsync(string Name)
        {
            byte[] imageArray;
            string base64ImageRepresentation;
            plc = await api3.getPlacesAsync();
            prs = await api3.getPersonAsync();
            getAllPht = await api3.getPhotosAsync();
            b64 = new List<string>();
            for(var i = 0; i < getAllPht.Count; i++)
            {
                for(var j= 0;j< getAllPht[i].Person.Count; j++)
                {
                    if (getAllPht[i].Person[j].Name == Name)
                    {
                        displayPht.Add(getAllPht[i]);
                    }
                }
            }

            //for (var i = 0; i < plc.Count; i++)
            //{
              //  imageArray = System.IO.File.ReadAllBytes(plc[i]);

              //  base64ImageRepresentation = Convert.ToBase64String(imageArray);
              //  b64.Add("data:image/jpg" + ";base64," + base64ImageRepresentation);
          //  }



        }
    }
}