using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MangaHut.Data.Entities
{
    public class Store
    {
        [Key]
        public int Id { get; set; }
        public Location Location{ get; set; }
        public string Name { get; set; } = "Manga Hut";
    }
}