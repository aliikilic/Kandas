using Entities.Dtos;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IPersonalInformationService
    {
        Task<List<PersonalInformation>> GetAllPersonsAsync(bool trackChanges);
        Task<PersonDto> GetOnePersonAsync(int id, bool trackChanges);
        Task<PersonDto> CreateOnePerson(PersonDto person, string email);
        Task UpdateOnePerson(PersonDto person,int id);
        Task DeleteOnePerson(int id,bool trackChanges);
        Task<int> GetPersonByUserId(string userid);
    }
}
