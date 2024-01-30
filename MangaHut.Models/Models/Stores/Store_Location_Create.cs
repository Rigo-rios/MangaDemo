using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MangaHut.Models.Models.Locations;

namespace MangaHut.Models.Models.Stores
{
    public class Store_Location_Create
    {
        public string Name { get; set; }= "Manga Hut";

        public LocationCreate Location { get; set; }
    }
}