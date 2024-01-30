using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MangaHut.Models.Models.Locations;

namespace MangaHut.Models.Models.Stores
{
    public class StoreDetail
    {
        public int Id { get; set; }
        public LocationListItem Location{ get; set; }
        public string Name { get; set; }
    }
}