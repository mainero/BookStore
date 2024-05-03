﻿using BookStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain
{
    public class Category : Entity
    {
        public string Name { get; set; }

        /* EF Relations */
        public IEnumerable<Book> Books { get; set; }
    }
}
