using Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Data.DbInfo
{
    public class BookDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<BookDbContext>();
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Title = "First Book",
                        Description = "First Description for this book",
                        Genre = "Biografy",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-4),
                        Rate = 4,
                        DateAdded = DateTime.Now,
                        UrlPath = "http/booksapi/firstbook",
                    },
                    new Book()
                    {
                        Title = "Second Book",
                        Description = "Second Description for this book",
                        Genre = "History",
                        IsRead = false,
                        UrlPath = "http/booksapi/secondbook",
                    },
                    new Book()
                    {
                        Title = "Five Book",
                        Description = "Five Description for this book",
                        Genre = "Roman",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-5),
                        Rate = 9,
                        DateAdded = DateTime.Now,
                        UrlPath = "http/booksapi/fivebook",
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
