using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MangaHut.Models.Models.Mangas;

namespace MangaHut.Services.MangaServices.Contracts
{
    public interface IMangaService
    {
        Task<bool> AddManga(MangaCreate model);
        Task<MangaDetail> GetManga(int id);
    }
}