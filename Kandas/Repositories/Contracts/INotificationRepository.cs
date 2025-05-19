using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface INotificationRepository : IRepositoryBase<Notification>
    {
        void CreateNotification(Notification notification);
        Task UpdateNotificationStatus(int notificationId,bool trackChanges);
        Task<Notification> GetNotificationsById(int id,bool trackChanges);
    }
}
