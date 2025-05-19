using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EfCore
{
    public class PersonalNotificationRepository : RepositoryBase<PersonalInformationNotifications>, IPersonalNotificationRepository
    {
        private readonly RepositoryContext _context;
        public PersonalNotificationRepository(RepositoryContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PersonalInformationNotifications>> GetAllPersonalNotifications(bool trackChanges)
        {
                var pinList =await _context.PersonalInformationNotifications.FromSqlRaw("select * from PersonalInformationNotification").ToListAsync();
            return pinList;
            
        }

        public async Task<IEnumerable<PersonalInformationNotifications>> GetPersonalNotificationsByPersonId(int personId)
        {
            return await _context.PersonalInformationNotifications.FromSqlInterpolated($"select * from PersonalInformationNotification where PersonalInformationId = {personId} ").ToListAsync();
        }
    }
}
