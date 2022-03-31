using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectifEFCore.Entities
{
    public class MovieConfig : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.Property("Title").HasMaxLength(100).IsRequired();
            builder.Property("Realisator").HasMaxLength(100).IsRequired();
            builder.Property("Genre").HasMaxLength(100).IsRequired();
            builder.Property("MainActor").HasMaxLength(100).IsRequired();
            builder.HasIndex(x => x.Title).IsUnique();
            builder.HasCheckConstraint("CK_Annee", "ReleaseYear > 1975");

            builder.HasData(
               new Movie
               {
                   Id = 1,
                   Title = "Star Wars : Un nouvel espoir",
                   ReleaseYear = 1977,
                   MainActor = "Mark Hammil",
                   Genre = "Science-Fiction",
                   Realisator = "Georges Lucas"
               },
               new Movie
               {
                   Id = 2,
                   Title = "Star Wars : L'empire contre-attaque",
                   ReleaseYear = 1980,
                   MainActor = "Mark Hammil",
                   Genre = "Science-Fiction",
                   Realisator = "Georges Lucas"
               },
               new Movie
               {
                   Id = 3,
                   Title= "Star Wars : Le retour du Jedi",
                   ReleaseYear = 1983,
                   MainActor = "Mark Hammil",
                   Genre = "Science-Fiction",
                   Realisator = "Georges Lucas"
               },
               new Movie
               {
                   Id = 4,
                   Title= "Hooligans",
                   ReleaseYear = 2005,
                   MainActor = "Charlie Hunnam",
                   Genre = "Société",
                   Realisator = "Lexi Alexander"
               },
               new Movie
               {
                   Id = 5,
                   Title = "LOTR - La communauté de l'anneau",
                   ReleaseYear = 2001,
                   MainActor = "Elijah Wood",
                   Genre = "Heroic-Fantasy",
                   Realisator = "Peter Jackson"
               },
               new Movie
               {
                   Id = 6,
                   Title = "LOTR - Les deux tours",
                   ReleaseYear = 2002,
                   MainActor = "Elijah Wood",
                   Genre = "Heroic-Fantasy",
                   Realisator = "Peter Jackson"
               },
               new Movie
               {
                   Id = 7,
                   Title = "LOTR - Le retour du roi",
                   ReleaseYear = 2003,
                   MainActor = "Elijah Wood",
                   Genre = "Heroic-Fantasy",
                   Realisator = "Peter Jackson"
               }
               );
        }
    }
}
