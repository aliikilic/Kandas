using AutoMapper;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Repositories.Contracts;
using Repositories.EfCore;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IAuthenticationService> _authenticationService;
        private readonly Lazy<IMailService> _mailService;
        private readonly Lazy<IPersonalInformationService> _personalInformationService;
        private readonly Lazy<IInquiryFormService> _inquiryFormService;
        private readonly Lazy<IRecepientService> _recepientService;
        private readonly Lazy<IDonationService> _donationService;
        private readonly Lazy<IDonationMovementService> _donationMovementService;
        private readonly Lazy<INotificationService> _notificationService;
        private readonly Lazy<ICityService> _cityService;
        private readonly Lazy<IDistrictService> _districtService;
        private readonly Lazy<INeighborhoodService> _neighborhoodService;
       
        public ServiceManager(IRepositoryManager repositoryManager, 
            IMapper mapper, 
            UserManager<User> userManager,
            IConfiguration configuration,
            RepositoryContext context) // contexti burada vermek hatalı olabilir !!!
        {
            _authenticationService = new Lazy<IAuthenticationService>(() => new AuthenticationManager(mapper, userManager, configuration));
            _mailService = new Lazy<IMailService>(() => new MailManager());
            _personalInformationService = new Lazy<IPersonalInformationService>(() => new PersonalInformationManager(repositoryManager, mapper));
            _inquiryFormService = new Lazy<IInquiryFormService>(()=> new InquiryFormManager(repositoryManager,mapper));
            _recepientService = new Lazy<IRecepientService>(()=> new RecepientManager(repositoryManager,mapper));
            _donationService = new Lazy<IDonationService>(() => new DonationManager(repositoryManager, mapper,context,new NotificationManager(repositoryManager, mapper,context),new DonationMovementManager(repositoryManager,mapper)));
            _donationMovementService = new Lazy<IDonationMovementService>(() => new DonationMovementManager(repositoryManager, mapper));
            _notificationService = new Lazy<INotificationService>(()=> new NotificationManager(repositoryManager, mapper,context));
            _cityService = new Lazy<ICityService>(() => new CityManager(repositoryManager, mapper));
            _districtService = new Lazy<IDistrictService>(() => new DistrictManager(repositoryManager, mapper));
            _neighborhoodService = new Lazy<INeighborhoodService>(()=> new NeighborhoodManager(repositoryManager, mapper));
        }
        public IAuthenticationService AuthenticationService => _authenticationService.Value;

        public IMailService MailService => _mailService.Value;

        public IPersonalInformationService PersonalInformationService => _personalInformationService.Value;

        public IInquiryFormService InquiryFormService => _inquiryFormService.Value;

        public IRecepientService ReceientService => _recepientService.Value;

        public IDonationService DonationService => _donationService.Value;

        public IDonationMovementService DonationMovementService => _donationMovementService.Value;

        public INotificationService NotificationService => _notificationService.Value;

        public ICityService CityService => _cityService.Value;

        public IDistrictService DistrictService => _districtService.Value;

        public INeighborhoodService NeighborhoodService => _neighborhoodService.Value;
    }
}
