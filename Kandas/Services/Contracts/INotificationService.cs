using Entities.Dtos;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface INotificationService
    {
        Task CreateNotification(CreateNotificationDto notification);
        Task UpdateNotificationStatus(int notificationId, bool trackChanges);
        List<Dictionary<string, object>> GetPersonalInformationNotifications();
        Task<List<NotificationListDto>> NotificationsByPersonId(int id);
        //List<>
    }
}
