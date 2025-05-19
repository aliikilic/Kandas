using Entities.Dtos;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IDonationService
    {
        Task CreateDonation(CreateDonationDto entity);
        Task<List<Donation>> GetAllDonation(bool trackChanges);
        Task<Donation> GetDonationByRecepientId(int id, bool trackChanges);
    }
}
