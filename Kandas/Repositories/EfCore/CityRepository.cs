using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EfCore
{
    public class CityRepository : RepositoryBase<City>, ICityRepository
    {
        public CityRepository(RepositoryContext context) : base(context)
        {
        }

        public async Task<List<City>> GetCities(bool trackChanges)
        {
            return await FindAll(trackChanges).ToListAsync();
        }
    }
}
