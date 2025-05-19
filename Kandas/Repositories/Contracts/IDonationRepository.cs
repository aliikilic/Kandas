using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IDonationRepository : IRepositoryBase<Donation>
    {
        void CreateDonation(Donation entity);
        Task<List<Donation>> GetAllDonation(bool trackChanges);
        Task<Donation> GetDonationByRecepientId(int id, bool trackChanges);
        Task<Donation> GetDonationById(int id, bool trackChanges);
        Task<List<int>> GetRecepientIdByDonId(int id, bool trackChanges);
    }
}
