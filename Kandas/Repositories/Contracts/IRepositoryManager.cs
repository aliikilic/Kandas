using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IPersonalInformationRepository PersonalInformation { get; }
        IAppUserRepository AppUser { get; }
        IInquiryFormRepository InquiryForm { get; }
        IRecepientRepository Recepient { get; }
        IDonationRepository Donation { get; }
        IDonationMovementRepository DonationMovement { get; }
        INotificationRepository Notification { get; }
        IPersonalNotificationRepository PersonalNotification { get; }
        ICityRepository City { get; }
        IDistrictRepository District { get; }
        INeighborhoodRepository Neighborhood { get; }
        Task SaveAsync();
        
    }
}
