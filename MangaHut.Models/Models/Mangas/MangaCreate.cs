using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MangaHut.Models.Models.Mangas
{
    public class MangaCreate
    {
                public string Author { get; set; }
        public string Title { get; set; } 
        public decimal Price { get; set; }
        public int MangaCount { get; set; }
    }
}