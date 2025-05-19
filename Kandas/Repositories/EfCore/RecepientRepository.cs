using Entities.Dtos;
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
    public class RecepientRepository : RepositoryBase<Recepient>, IRecepientRepository
    {
        public RecepientRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateRecepient(Recepient entity) => Create(entity);

        public async Task<List<Recepient>> GetAllRecepients(bool trackChanges)
        {
            return await FindAll(trackChanges).OrderBy(r => r.Name).ToListAsync();
        }
        public async Task<RecepientNSBDto> GetRecepientsById(int id, bool trackChanges) 
        {
            var result = await FindByCondition(r => r.Id.Equals(id), false)
                .Select(r => new RecepientNSBDto()
                {
                Name= r.Name,
                Surname = r.Surname,
                BloodType = r.BloodType

            }).FirstOrDefaultAsync();

            return result;

            
        }
    }
}
