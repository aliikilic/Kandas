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
    public class NotificationRepository : RepositoryBase<Notification>, INotificationRepository
    {
        public NotificationRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateNotification(Notification notification) => Create(notification);

        public async Task<Notification> GetNotificationsById(int id,bool trackChanges)
        {
            var entity = await FindByCondition(x => x.NotificationId.Equals(id), trackChanges).SingleOrDefaultAsync();
            return entity;
        }

        public async Task UpdateNotificationStatus(int notificationId, bool trackChanges)
        {
            var entity = await FindByCondition(x => x.NotificationId.Equals(notificationId),trackChanges).SingleOrDefaultAsync();
            bool result = entity.IsActive == true ? false : true;
            entity.IsActive = result;
            Update(entity);
        }
    }
}
