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
    public class PersonalInformationRepository : RepositoryBase<PersonalInformation>, IPersonalInformationRepository
    {
        public PersonalInformationRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateOnePerson(PersonalInformation person) => Create(person);

        public void DeleteOnePerson(int id)
        {
            var person = FindByCondition(p => p.PersonalInformationId.Equals(id),true).FirstOrDefault();
            person.IsActive = false;
            Update(person);
            
        }

        public async Task<List<PersonalInformation>> GetAllPersonsAsync(bool trackChanges)
        {
            var persons = await FindAll(trackChanges)
                .OrderBy(p => p.Name)
                .ToListAsync();

            return persons;
        }

        public async Task<PersonalInformation> GetOnePersonAsync(int id, bool trackChanges)
        {
            return await FindByCondition(p => p.PersonalInformationId.Equals(id), trackChanges).SingleOrDefaultAsync();
        }

        public void UpdateOnePerson(PersonalInformation person) => Update(person);
    }
}
