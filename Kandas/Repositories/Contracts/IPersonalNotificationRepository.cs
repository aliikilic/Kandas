using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IPersonalNotificationRepository : IRepositoryBase<PersonalInformationNotifications>
    {
        Task<IEnumerable<PersonalInformationNotifications>> GetAllPersonalNotifications(bool trackChanges);
        Task<IEnumerable<PersonalInformationNotifications>> GetPersonalNotificationsByPersonId(int personId);
    }
}
