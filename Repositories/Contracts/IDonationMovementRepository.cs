using Entities.Dtos;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IDonationMovementRepository : IRepositoryBase<DonationMovement>
    {
        void CreteDonationMovement(DonationMovement movement);
        void UpdateDonationMovementStatus(int id, int statusId, bool trackChanges);
        Task<List<DonationMovement>> GetDonationMovementsAsync(bool trackChanges);
        Task<DonationMovement> GetOneDonationMovementById(int id,bool trackChanges);
        Task<List<DonationMovement>> GetDonationMovementsByPersonId(int id, bool trackChanges);
        Hospital GetHospitalByID(int id,bool trackChanges);
        DonationType GetDonationTypeNameById(int typeid);
        List<Hospital> GetHospitalLists();
        
    }
}
