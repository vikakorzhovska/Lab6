using DigitalLibrary.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalLibrary.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Books.Any()) return; 

            var authors = new[]
            {
                new Author { FullName = "George Orwell", Biography = "English novelist and essayist" },
                new Author { FullName = "J.K. Rowling", Biography = "British author" }
            };
            context.Authors.AddRange(authors);
            context.SaveChanges();

            var publishers = new[]
            {
                new Publisher { Name = "Penguin Books", Address = "London" },
                new Publisher { Name = "Bloomsbury", Address = "UK" }
            };
            context.Publishers.AddRange(publishers);
            context.SaveChanges();

            var books = new[]
            {
                new Book
                {
                    Title = "1984",
                    Description = "Dystopian novel",
                    PublishDate = new DateTime(1949, 6, 8),
                    Author = authors[0],
                    Publisher = publishers[0]
                },
                new Book
                {
                    Title = "Harry Potter",
                    Description = "Fantasy novel",
                    PublishDate = new DateTime(1997, 6, 26),
                    Author = authors[1],
                    Publisher = publishers[1]
                }
            };
            context.Books.AddRange(books);
            context.SaveChanges();
        }
    }
}
