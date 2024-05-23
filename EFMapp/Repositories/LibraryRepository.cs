using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EFMapp.DbContexts;
using EFMapp.Entities.Library;

namespace EFMapp.Repositories
{
    public class LibraryRepository
    {
        private LibraryContext _context;
        public LibraryRepository(LibraryContext context)
        {
            _context = context;
        }

        public void Initialize()
        {
            using (var context = new LibraryContext())
            {
                var author = new Author { Name = "P.L. Deshpande" };
                author.Blogs = new List<Blog>
                {
                    new Blog { Title = "Batatychi Chal" },
                    new Blog { Title = "Purvrang" },
                    new Blog { Title = "Gulacha Ganpati" }
                };
                context.Author.Add(author);
                context.SaveChanges();
            }
        }
        public void ShowAll()
        {
            using (var context = new LibraryContext())
            {
                var authorsWithBlogs = context.Author.Include(a => a.Blogs).ThenInclude(b=> b.Posts).ToList();

                foreach (var author in authorsWithBlogs)
                {
                    Console.WriteLine($"Author: {author.Name}");

                    foreach (var blog in author.Blogs)
                    {
                        Console.WriteLine($" - Blog: {blog.Title}");
                        foreach (var post in blog.Posts)
                        {
                            Console.WriteLine($" - Post: {post.Title}");
                        }
                    }

                }
            }
        }
    }
}
