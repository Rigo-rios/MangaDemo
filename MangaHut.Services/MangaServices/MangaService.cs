using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MangaHut.Data;
using MangaHut.Data.Entities;
using MangaHut.Models.Models.Mangas;
using MangaHut.Models.Models.Store_Manga;
using MangaHut.Services.MangaServices.Contracts;

namespace MangaHut.Services.MangaServices
{
    public class MangaService : IMangaService
    {

        private readonly AppDbContext _context;

        public MangaService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddManga(MangaCreate model)
        {
            var entity = new Manga
            {
                Author = model.Author,
                Title = model.Title,
                Price = model.Price,
                MangaCount = model.MangaCount
            };
            await _context.Manga.AddAsync(entity);
            return await _context.SaveChangesAsync() > 0;

        }

        public async Task<MangaDetail> GetManga(int id)
        {
            var mangaInDb = await _context.Manga.FindAsync(id);
            if (mangaInDb is null) return null;

            return new MangaDetail
            {
                Id = mangaInDb.Id,
                Author = mangaInDb.Author,
                Title = mangaInDb.Title,
                Price = mangaInDb.Price,
                MangaCount = mangaInDb.MangaCount
            };
        }
    }
}