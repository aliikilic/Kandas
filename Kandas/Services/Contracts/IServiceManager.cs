using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IServiceManager
    {
        IAuthenticationService AuthenticationService { get; }
        IPersonalInformationService PersonalInformationService { get; }
        IInquiryFormService InquiryFormService { get; }
        IRecepientService ReceientService { get; }
        IMailService MailService { get; }
        IDonationService DonationService { get; }
        IDonationMovementService DonationMovementService { get; }
        INotificationService NotificationService { get; }
        ICityService CityService { get; }
        IDistrictService DistrictService { get; }
        INeighborhoodService NeighborhoodService { get; }
    }
}
