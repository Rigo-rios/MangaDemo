using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MangaHut.Data.Entities
{
    public class Location
    {
        public int Id { get; set; }
        [MaxLength(150, ErrorMessage= "Cannot exceed 150 Characters.")]
        [MinLength(10, ErrorMessage= "Must have more then 10 characters.")]
        public string City { get; set; } = string.Empty;
        [MaxLength(100, ErrorMessage= "Cannot exceed 100 Characters.")]
        [MinLength(3, ErrorMessage= "Must have more then 3 characters.")]
        public string Address { get; set; } = string.Empty;
        [MaxLength(150, ErrorMessage= "Cannot exceed 150 Characters.")]
        [MinLength(10, ErrorMessage= "Must have more then 10 characters.")]
        public string State { get; set; } = string.Empty;
        [MaxLength(20, ErrorMessage= "Cannot exceed 20 Characters.")]
        [MinLength(5, ErrorMessage= "Must have more then 5 characters.")]
        public string ZipCode { get; set; } = string.Empty;
        public int StoreId { get; set; }
        [ForeignKey(nameof(StoreId))]
        public Store Store { get; set; }

    }
}