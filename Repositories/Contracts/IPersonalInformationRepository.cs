using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IPersonalInformationRepository : IRepositoryBase<PersonalInformation>
    {
        Task<List<PersonalInformation>> GetAllPersonsAsync(bool trackChanges);
        Task<PersonalInformation> GetOnePersonAsync(int id, bool trackChanges);
        void CreateOnePerson(PersonalInformation person);
        void UpdateOnePerson(PersonalInformation person);
        void DeleteOnePerson(int id);
        
    }
}
