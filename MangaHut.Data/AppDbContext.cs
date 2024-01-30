using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MangaHut.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MangaHut.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}

        public DbSet<Store> Stores { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Manga> Manga { get; set; }
        public DbSet<StoreManga> StoreMangas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Store>().HasData(
                new Store
                {
                    Id=1
                }
            );
            modelBuilder.Entity<Location>().HasData(
                new Location
                {
                    Id=1,
                    Address = "123 Street court",
                    City = "Indianapolis",
                    State = "Indiana",
                    ZipCode = "612456",
                    StoreId = 1,
                }
            );
            modelBuilder.Entity<Manga>().HasData(
                new Manga{
                    Id= 1
                    ,Title="Death Note"
                    ,Author = "Tsugumi Ohbi"
                }
            );
                modelBuilder.Entity<StoreManga>().HasData(
                new StoreManga{
                    Id= 1,
                    StoreId = 1,
                    MangaId =1 ,
                }
            );
        }
    }
}