using SupermarketAPI.Domain.Models;
using SupermarketAPI.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupermarketAPI.Services
{
    public class CategoryService : ICategoryService
    {
        public Task<IEnumerable<Category>> ListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
