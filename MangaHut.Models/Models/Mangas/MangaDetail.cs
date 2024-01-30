using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MangaHut.Models.Models.Mangas
{
    public class MangaDetail
    {
        public int Id { get; set; }
        public string Author { get; set; } = string.Empty; 
        public string Title { get; set; } = string.Empty;
        public decimal Price { get; set; } = 3.99m;
        public int MangaCount { get; set; } = 100;
    }
}