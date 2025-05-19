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
    public class DonationMovementRepository : RepositoryBase<DonationMovement>, IDonationMovementRepository
    {
        private readonly RepositoryContext _context;
        public DonationMovementRepository(RepositoryContext context) : base(context)
        {
            _context = context;
        }

        public void CreteDonationMovement(DonationMovement movement) => Create(movement);

        public async Task<List<DonationMovement>> GetDonationMovementsAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).ToListAsync();
        }

        public async Task<List<DonationMovement>> GetDonationMovementsByPersonId(int id, bool trackChanges)
        {
            return await FindByCondition(x => x.PersonId.Equals(id), trackChanges).ToListAsync();
        }

        public async Task<DonationMovement> GetOneDonationMovementById(int id, bool trackChanges)
        {
            return await FindByCondition(x => x.Id.Equals(id),trackChanges).SingleOrDefaultAsync();

        }

        public void UpdateDonationMovementStatus(int id, int statusId,bool trackChanges)
        {
            var entity = FindByCondition(x => x.Id.Equals(id),trackChanges).SingleOrDefault();
            entity.MovementStatusId = statusId;
            Update(entity);
        }

        public Hospital GetHospitalByID(int id, bool trackChanges)
        {
             var hospitals = _context.Hospitals.FromSqlInterpolated($"select * from Hospitals where ID = {id}").FirstOrDefault();
            
            return hospitals;
        }

        public DonationType GetDonationTypeNameById(int typeid)
        {
            var type = _context.DonationTypes.FromSqlInterpolated($"select * from DonationTypes where Id = {typeid}").FirstOrDefault();
            return type;
        }
        public List<Hospital> GetHospitalLists()
        {
            var list = _context.Hospitals.FromSqlRaw("select * from Hospitals").ToList();
            return list;
        }
    }
}
/*
  public List<GetHospitalDto> GetHospitalList(bool trackChanges)
        {
            var list = _manager.DonationMovement.GetHospitalList(trackChanges);
            return list;
        }
 
 */
