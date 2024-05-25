﻿// <auto-generated />
using GastroWebsiteNew.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GastroWebsiteNew.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240525075852_newimgs")]
    partial class newimgs
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GastroWebsiteNew.Models.Place", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePaths")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Places");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A unique dining experience with its picturesque waterfront setting and a menu featuring authentic Filipino cuisine, capturing the essence of local flavors amidst breathtaking views.",
                            ImagePaths = "[\"lantaw.jpg\",\"lantaw1.jpg, lantaw2.jpg\"]",
                            Location = "Il Corso",
                            Name = "Lantaw",
                            Type = "Restaurant"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Offers a cozy ambiance and a diverse menu of delicious coffee blends and delectable treats, making it the perfect spot to unwind and enjoy a delightful culinary experience.",
                            ImagePaths = "[\"tamp.jpg\",\"tamp1.jpg, tamp2.jpg\"]",
                            Location = "Paseo Arcenas, Banawa",
                            Name = "Tamp Cafe & Co",
                            Type = "Restaurant"
                        },
                        new
                        {
                            Id = 3,
                            Description = "A sophisticated rooftop dining experience with panoramic views of the city skyline and ocean, complemented by a diverse menu of international cuisine and signature cocktails, perfect for a memorable evening under the stars.",
                            ImagePaths = "[\"scape.jpg\",\"scape1.jpg, scape2.jpg\"]",
                            Location = "AZON Residences, Roof Deck, M.L. Quezon National Highway, Lapu-Lapu City",
                            Name = "Scape Skydeck",
                            Type = "Restaurant"
                        },
                        new
                        {
                            Id = 4,
                            Description = "A delightful fusion of artisanal baked goods, gourmet sandwiches, and specialty coffee in a cozy, chic setting, embodying a haven for pastry enthusiasts and foodies alike in Cebu.",
                            ImagePaths = "[\"abaca.jpg\",\"abaca1.jpg, abaca.jpg\"]",
                            Location = "Paseo Arcenas, Banawa",
                            Name = "Abaca Baking Company",
                            Type = "Cafe"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Epitomizes culinary excellence with its innovative dishes inspired by global flavors, served in a stylish yet inviting atmosphere, setting the standard for modern dining experiences in Cebu.",
                            ImagePaths = "[\"pig.jpg\",\"pig1.jpg, pig2.jpg\"]",
                            Location = "G/F, MSY Tower, Negros Rd, Cebu City",
                            Name = "The Pig and Palm",
                            Type = "Restaurant"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Beckons with its charming seaside ambiance and delectable seafood offerings, providing a memorable dining experience by the shore in Cebu.",
                            ImagePaths = "[\"lighthouse.jpg\",\"lighthouse1.jpg, lighthouse2.jpg\"]",
                            Location = "General Maxilom Ave, Cebu City",
                            Name = "Lighthouse Restaurant",
                            Type = "Restaurant"
                        },
                        new
                        {
                            Id = 7,
                            Description = "A diverse culinary journey with its fusion of local and international flavors, promising a cozy and vibrant dining atmosphere.",
                            ImagePaths = "[\"cafebai.jpeg\",\"cafebai1.jpg, cafebai2.jpeg\"]",
                            Location = "Ouano Ave, cor C.D.Seno, Mandaue City",
                            Name = "Cafe Bai",
                            Type = "Cafe"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Delights discerning diners with its elegant ambiance and exquisite Mediterranean-inspired cuisine, delivering a sophisticated culinary experience.",
                            ImagePaths = "[\"anzani.png\",\"anzani1.jpg, anzani.jpg\"]",
                            Location = "Panorama Heights Nivel Hills, Cebu City",
                            Name = "Anzani Restaurant",
                            Type = "Restaurant"
                        },
                        new
                        {
                            Id = 9,
                            Description = "A cozy retreat for bookworms and coffee lovers alike, combining a curated selection of literature with aromatic brews for a tranquil escape.",
                            ImagePaths = "[\"cafetalk.jpg\",\"cafetalk1.jpg, cafetalk2.jpg\"]",
                            Location = "Escario Building, 731 N Escario St, Cebu City",
                            Name = "Cafe Talk Library",
                            Type = "Cafe"
                        });
                });

            modelBuilder.Entity("GastroWebsiteNew.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlaceId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlaceId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("GastroWebsiteNew.Models.Review", b =>
                {
                    b.HasOne("GastroWebsiteNew.Models.Place", "Place")
                        .WithMany("Reviews")
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Place");
                });

            modelBuilder.Entity("GastroWebsiteNew.Models.Place", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
