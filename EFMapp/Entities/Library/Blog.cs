using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMapp.Entities.Library
{
    public class Blog
    {
        public int    Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }

        public List<Post> Posts { get; set; }
    }
}
