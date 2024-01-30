using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MangaHut.Models.Models.Stores;

namespace MangaHut.Models.Models.Locations
{
    public class LocationDetail
    {
        public int Id { get; set; }

        public string City { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;

        public StoreListItem Store { get; set; }

    }
}