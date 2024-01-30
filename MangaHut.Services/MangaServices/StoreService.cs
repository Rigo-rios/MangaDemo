using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using MangaHut.Data;
using MangaHut.Data.Entities;
using MangaHut.Models.Models.Locations;
using MangaHut.Models.Models.Stores;
using MangaHut.Services.MangaServices.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Query;

namespace MangaHut.Services.MangaServices
{
    public class StoreService : IStoreService
    {
        private readonly AppDbContext _context;

        public StoreService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddStore(StoreCreate model)
        {
            Store Entity = new Store
            {
                Name = model.Name
            };

            await _context.Stores.AddAsync(Entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> AddStore_Location(Store_Location_Create model)
        {
            Store entity = new Store
            {
                Name = model.Name
            };
            await _context.Stores.AddAsync(entity);
            await _context.SaveChangesAsync();

            Location locationModel = new Location
            {
                Address = model.Location.Address,
                City = model.Location.City,
                State = model.Location.State,
                ZipCode = model.Location.ZipCode,
                StoreId = entity.Id

            };
            await _context.AddAsync(locationModel);
            return await _context.SaveChangesAsync() >0;
        }

        public async Task<bool> EditStore(StoreEdit model)
        {
            Store storeInDb = await _context.Stores.FindAsync(model.Id)!;
            if(storeInDb is null)
            {
                return false;
            }
            storeInDb.Name = model.Name;
            return await _context.SaveChangesAsync() >0;
        }

        public async Task<StoreDetail> GetStore(int id)
        {
                Store storeInDb = 
                await _context
                .Stores.Include(s=>s.Location)
                .SingleOrDefaultAsync(x=>x.Id== id);
            if(storeInDb is null)
            {
                return null;
            }
            return new StoreDetail
            {
                Id = storeInDb.Id,
                Name = storeInDb.Name,
                Location = new LocationListItem
                {
                    Id = storeInDb.Location.Id,
                    Address = storeInDb.Location.Address,
                    ZipCode = storeInDb.Location.ZipCode
                }
            };
        }

        public Task<List<StoreListItem>> GetStores()
        {
            return _context.Stores.Include(s=>s.Location).Select(s=> new StoreListItem
            {
                Id=s.Id,
                Name = s.Name,
                Location = new LocationListItem
                {
                    Id = s.Location.Id,
                    Address = s.Location.Address,
                    ZipCode = s.Location.ZipCode
                }
            }
            ).ToListAsync();
        }
    }
}