using Entities.Dtos;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IRecepientRepository : IRepositoryBase<Recepient>
    {
        void CreateRecepient(Recepient entity);
        Task<List<Recepient>> GetAllRecepients(bool trackChanges);
        Task<RecepientNSBDto> GetRecepientsById(int id, bool trackChanges);
    }
}
