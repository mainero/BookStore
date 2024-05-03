using BookStore.Domain.Interfaces;
using BookStore.Domain;
using BookStore.Infraestructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Infraestructure.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(BookStoreDbContext context) : base(context) { }
    }
}
