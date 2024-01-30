using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MangaHut.Data.Entities;

namespace MangaHut.Models.Models.Store_Manga
{
    public class Store_Manga_Create
    {
        public int StoreId { get; set; } 

        public int MangaId { get; set; }


    }
}