using Entities.Dtos;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IRecepientService
    {
        Task CreateRecepient(CreateRecepientDto entity);
        Task<List<Recepient>> GetAllRecepients(bool trackChanges);
        Task<int> GetRecepientIdByTCKN(string tckn);
    }
}
