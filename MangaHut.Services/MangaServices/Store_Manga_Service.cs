using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MangaHut.Data;
using MangaHut.Data.Entities;
using MangaHut.Models.Models.Mangas;
using MangaHut.Models.Models.Store_Manga;
using MangaHut.Services.MangaServices.Contracts;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MangaHut.Services.MangaServices
{
    public class Store_Manga_Service : IStore_Manga_Service
    {
        private readonly AppDbContext _context;

        public Store_Manga_Service(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddManga(Store_Manga_Create model)
        {
            var entity = new StoreManga
            {
                StoreId = model.StoreId,
                MangaId = model.MangaId
            };
            await _context.StoreMangas.AddAsync(entity);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}