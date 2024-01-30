using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MangaHut.Models.Models.Locations;

namespace MangaHut.Services.MangaServices.Contracts
{
    public interface ILocationService
    {
        Task<bool> AddLocation(LocationCreate model);
        Task<LocationDetail> GetLocation(int id);
        Task<List<LocationListItem>> GetLocations();
    }
}