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
    public class NeighborhoodRepository : RepositoryBase<Neighborhood>, INeighborhoodRepository
    {
        public NeighborhoodRepository(RepositoryContext context) : base(context)
        {
        }

        public async Task<List<Neighborhood>> GetNeighborhoods(bool trackChanges)
        {
            return await FindAll(trackChanges).ToListAsync();
        }
    }
}
