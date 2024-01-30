using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MangaHut.Data;
using MangaHut.Data.Entities;
using MangaHut.Models.Models.Locations;
using MangaHut.Services.MangaServices.Contracts;
using Microsoft.EntityFrameworkCore;

namespace MangaHut.Services.MangaServices
{
    public class LocationServices : ILocationService
    {
        private readonly AppDbContext _context;

        public LocationServices(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddLocation(LocationCreate model)
        {
            var entity = new Location
            {
                Address = model.Address,
                City = model.City,
                State = model.State,
                ZipCode = model.ZipCode,
            };
            await _context.Locations.AddAsync(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<LocationDetail> GetLocation(int id)
        {
            Location locationInDb = await 
            _context
            .Locations
            .FirstOrDefaultAsync(x=>x.Id == id);

            if(locationInDb is null) return null;

            return new LocationDetail
            {
                Id= locationInDb.Id,
            Address = locationInDb.Address,
            ZipCode = locationInDb.ZipCode,
            State = locationInDb.State,
            StoreName = locationInDb.Store.Name
        };
    }

        public async Task<List<LocationListItem>> GetLocations()
        {
            return await  _context.Locations.Select(l=> new LocationListItem
            {
                Id =l.Id,
                Address = l.Address,
                ZipCode = l.ZipCode
            }).ToListAsync();
        }
        
    }
}