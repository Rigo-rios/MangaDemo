using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MangaHut.Models.Models.Locations
{
    public class LocationListItem
    {
        public int Id { get; set; }
        public string Address { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;

    }
}