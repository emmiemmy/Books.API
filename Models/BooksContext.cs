using System;
using Microsoft.EntityFrameworkCore;

namespace Books.API.Models
{
    public class BooksContext : DbContext
    {

        public BooksContext(DbContextOptions<BooksContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        //Seed data for testing, not working atm.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Books Table
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = "B01",
                Author = "Kutner, Joe",
                Title = "Deploying with JRuby",
                Genre = "Computer",
                Price = 33.00,
                PublishedDate = new DateTime(2012-08-15),
                Description = "Deploying with JRuby is the missing link between enjoying JRuby and using it in the real world to build high-performance, scalable applications."
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = "B02",
                Author = "Ralls, Kim",
                Title = "Midnight Rain",
                Genre = "Fantasy",
                Price = 5.95,
                PublishedDate = new DateTime(2000-12-16),
                Description = "A former architect battles corporate zombies, an evil sorceress, and her own childhood to become queen of the world."
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = "B03",
                Author = "Corets, Eva",
                Title = "Maeve Ascendant",
                Genre = "Fantasy",
                Price = 5.95,
                PublishedDate = new DateTime(2000-11-17),
                Description = "After the collapse of a nanotechnology society in England, the young survivors lay the foundation for a new society."
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = "B04",
                Author = "Corets, Eva",
                Title = "Oberon's Legacy",
                Genre = "Fantasy",
                Price = 5.95,
                PublishedDate = new DateTime(2001-03-10),
                Description = "In post-apocalypse England, the mysterious agent known only as Oberon helps to create a new life for the inhabitants of London. Sequel to Maeve Ascendant."
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = "B05",
                Author = "Tolkien, JRR",
                Title = "The Hobbit",
                Genre = "Fantasy",
                Price = 11.95,
                PublishedDate = new DateTime(1985-09-10),
                Description = "If you care for journeys there and back, out of the comfortable Western world, over the edge of the Wild, and home again, and can take an interest in a humble hero blessed with a little wisdom and a little courage and considerable good luck, here is a record of such a journey and such a traveler."
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = "B06",
                Author = "Randall, Cynthia",
                Title = "Lover Birds",
                Genre = "Romance",
                Price = 4.95,
                PublishedDate = new DateTime(2000-09-02),
                Description = "When Carla meets Paul at an ornithology conference, tempers fly as feathers get ruffled."
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = "B07",
                Author = "Thurman, Paula",
                Title = "Splish Splash",
                Genre = "Romance",
                Price = 4.95,
                PublishedDate = new DateTime(2000-11-02),
                Description = "A deep sea diver finds true love twenty thousand leagues beneath the sea."
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = "B08",
                Author = "Knorr, Stefan",
                Title = "Creepy Crawlies",
                Genre = "Horror",
                Price = 4.95,
                PublishedDate = new DateTime(2000-12-06),
                Description = "An anthology of horror stories about roaches, centipedes, scorpions  and other insects."
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = "B09",
                Author = "Kress, Peter",
                Title = "Paradox Lost",
                Genre = "Science Fiction",
                Price = 6.95,
                PublishedDate = new DateTime(2000-11-02),
                Description = "After an inadvertant trip through a Heisenberg Uncertainty Device, James Salway discovers the problems of being quantum."
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = "B10",
                Author = "O'Brien, Tim",
                Title = "Microsoft .NET: The Programming Bible",
                Genre = "Computer",
                Price = 36.95,
                PublishedDate = new DateTime(2000-12-09),
                Description = "Microsoft's .NET initiative is explored in detail in this deep programmer's reference."
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = "B11",
                Author = "Sydik, Jeremy J",
                Title = "Design Accessible Web Sites",
                Genre = "Computer",
                Price = 34.95,
                PublishedDate = new DateTime(2007-12-01),
                Description = "Accessibility has a reputation of being dull, dry, and unfriendly toward graphic design. But there is a better way: well-styled semantic markup that lets you provide the best possible results for all of your users. This book will help you provide images, video, Flash and PDF in an accessible way that looks great to your sighted users, but is still accessible to all users."
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = "B12",
                Author = "Russell, Alex",
                Title = "Mastering Dojo",
                Genre = "Computer",
                Price = 38.95,
                PublishedDate = new DateTime(2008-06-01),
                Description = "The last couple of years have seen big changes in server-side web programming. Now it’s the client’s turn; Dojo is the toolkit to make it happen and Mastering Dojo shows you how."
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = "B13",
                Author = "Copeland, David Bryant",
                Title = "Build Awesome Command-Line Applications in Ruby",
                Genre = "Computer",
                Price = 20.00,
                PublishedDate = new DateTime(2012-03-01),
                Description = "Speak directly to your system. With its simple commands, flags, and parameters, a well-formed command-line application is the quickest way to automate a backup, a build, or a deployment and simplify your life."
            });

        }

    }
}