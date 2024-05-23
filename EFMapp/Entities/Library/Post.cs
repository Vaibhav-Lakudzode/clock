﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMapp.Entities.Library
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }


        public Blog Blog { get; set; }
    }
}
