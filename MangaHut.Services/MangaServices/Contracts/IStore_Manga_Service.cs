using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MangaHut.Data.Entities;
using MangaHut.Models.Models.Store_Manga;

namespace MangaHut.Services.MangaServices.Contracts
{
    public interface IStore_Manga_Service
    {
        Task<bool> AddManga(Store_Manga_Create model);
    }
}