using Microsoft.EntityFrameworkCore;
using GastroWebsiteNew.Models;
using System.Collections.Generic; // Add this namespace for List<T>

namespace GastroWebsiteNew.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Place> Places { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed some sample places
            modelBuilder.Entity<Place>().HasData(
                new Place { Id = 1, Name = "Lantaw", Type = "Restaurant", Location = "Il Corso", ImagePaths = new List<string> { "lantaw.jpg", "lantaw1.jpg", "lantaw2.jpg" }, Description = "Delights patrons with its artisanal pastries, gourmet sandwiches, and specialty coffee, all served in a warm and inviting atmosphere." },
                new Place { Id = 2, Name = "Tamp Cafe & Co", Type = "Restaurant", Location = "Paseo Arcenas, Banawa", ImagePaths = new List<string> { "tamp.jpg", "tamp1.jpg", "tamp2.jpg" }, Description = "Offers a cozy ambiance and a diverse menu of delicious coffee blends and delectable treats, making it the perfect spot to unwind and enjoy a delightful culinary experience." },
                new Place { Id = 3, Name = "Scape Skydeck", Type = "Restaurant", Location = "AZON Residences, Roof Deck, M.L. Quezon National Highway, Lapu-Lapu City", ImagePaths = new List<string> { "scape.jpg", "scape1.jpg", "scape2.jpg" }, Description = "A sophisticated rooftop dining experience with panoramic views of the city skyline and ocean, complemented by a diverse menu of international cuisine and signature cocktails, perfect for a memorable evening under the stars." },
                new Place { Id = 4, Name = "Abaca Baking Company", Type = "Cafe", Location = "Paseo Arcenas, Banawa", ImagePaths = new List<string> { "abaca.jpg", "abaca1.jpg", "abaca2.jpg" }, Description = "A delightful fusion of artisanal baked goods, gourmet sandwiches, and specialty coffee in a cozy, chic setting, embodying a haven for pastry enthusiasts and foodies alike in Cebu." },
                new Place { Id = 5, Name = "The Pig and Palm", Type = "Restaurant", Location = "G/F, MSY Tower, Negros Rd, Cebu City", ImagePaths = new List<string> { "pig.jpg", "pig1.jpg", "pig2.jpg" }, Description = "Epitomizes culinary excellence with its innovative dishes inspired by global flavors, served in a stylish yet inviting atmosphere, setting the standard for modern dining experiences in Cebu." },
                new Place { Id = 6, Name = "Lighthouse Restaurant", Type = "Restaurant", Location = "General Maxilom Ave, Cebu City", ImagePaths = new List<string> { "lighthouse.jpg", "lighthouse1.jpg", "lighthouse2.jpg" }, Description = "Beckons with its charming seaside ambiance and delectable seafood offerings, providing a memorable dining experience by the shore in Cebu." },
                new Place { Id = 7, Name = "Cafe Bai", Type = "Cafe", Location = "Ouano Ave, cor C.D.Seno, Mandaue City", ImagePaths = new List<string> { "cafebai.jpeg", "cafebai1.jpg", "cafebai2.jpeg" }, Description = "Offers a vibrant dining experience with an extensive selection of local and international cuisines, set in a stylish and welcoming atmosphere." },
                new Place { Id = 8, Name = "Anzani Restaurant", Type = "Restaurant", Location = "Panorama Heights Nivel Hills, Cebu City", ImagePaths = new List<string> { "anzani.png", "anzani1.jpg", "anzani2.jpg" }, Description = "Delights discerning diners with its elegant ambiance and exquisite Mediterranean-inspired cuisine, delivering a sophisticated culinary experience." },
                new Place { Id = 9, Name = "Cafe Talk Library", Type = "Cafe", Location = "Escario Building, 731 N Escario St, Cebu City", ImagePaths = new List<string> { "cafetalk.jpg", "cafetalk1.jpg", "cafetalk2.jpg" }, Description = "Combines the cozy ambiance of a café with a curated selection of books, offering a serene haven for coffee enthusiasts and avid readers alike." }
               
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
