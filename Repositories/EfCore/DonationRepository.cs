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
    public class DonationRepository : RepositoryBase<Donation>, IDonationRepository
    {
        public DonationRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateDonation(Donation entity) => Create(entity);

        public async Task<List<Donation>> GetAllDonation(bool trackChanges)
        {
            return await FindAll(trackChanges).OrderBy(x => x.NecessityStartDate).ToListAsync();
            
        }

        public async Task<Donation> GetDonationById(int id, bool trackChanges)
        {
            return await FindByCondition(x => x.DonationId.Equals(id), trackChanges).FirstOrDefaultAsync();
        }

        public async Task<Donation> GetDonationByRecepientId(int id,bool trackChanges)
        {
            return await FindByCondition(x => x.RecepientId.Equals(id), trackChanges).FirstOrDefaultAsync();
        }
        public async Task<List<int>> GetRecepientIdByDonId(int id, bool trackChanges)
        {
            return await FindByCondition(x => x.DonationId.Equals(id), trackChanges).Select(d => d.RecepientId).ToListAsync();
        }
    }
}
