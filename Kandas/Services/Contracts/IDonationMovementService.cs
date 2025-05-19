using Entities.Dtos;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IDonationMovementService
    {
        Task CreteDonationMovement();
        Task UpdateDonationMovementStatus(int id, int statusId, bool trackChanges);
        Task<List<DonationMovement>> GetDonationMovementsAsync(bool trackChanges);
        Task<DonationMovement> GetOneDonationMovementById(int id, bool trackChanges);
        Task<List<PreviousDonationsDto>> GetDonationMovementsByPersonId(int id, bool trackChanges);
        List<GetHospitalDto> GetHospitalList();
        //List<>
    }
}
