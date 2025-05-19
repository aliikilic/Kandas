using Microsoft.EntityFrameworkCore.Query.Internal;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EfCore
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly Lazy<IPersonalInformationRepository> _personalInformationRepository;
        private readonly Lazy<IAppUserRepository> _appUserRepository;
        private readonly Lazy<IInquiryFormRepository> _inquiryFormRepository;
        private readonly Lazy<IRecepientRepository> _recepientRepository;
        private readonly Lazy<IDonationRepository> _donationRepository;
        private readonly Lazy<IDonationMovementRepository> _donationMovementRepository;
        private readonly Lazy<INotificationRepository> _notificationRepository;
        private readonly Lazy<IPersonalNotificationRepository> _personalNotificationRepository;
        private readonly Lazy<ICityRepository> _cityRepository;
        private readonly Lazy<IDistrictRepository> _districtRepository;
        private readonly Lazy<INeighborhoodRepository> _neighborhoodRepository;
        public RepositoryManager(RepositoryContext context)
        {
            _context = context;
            _personalInformationRepository = new Lazy<IPersonalInformationRepository>(() => new PersonalInformationRepository(context));
            _appUserRepository = new Lazy<IAppUserRepository>(() => new AppUserRepository(context));
            _inquiryFormRepository = new Lazy<IInquiryFormRepository>(() => new InquiryFormRepository(context));
            _recepientRepository = new Lazy<IRecepientRepository>(() => new RecepientRepository(context));
            _donationRepository = new Lazy<IDonationRepository>(() => new DonationRepository(context));
            _donationMovementRepository = new Lazy<IDonationMovementRepository>(() => new DonationMovementRepository(context));
            _notificationRepository = new Lazy<INotificationRepository>(() => new NotificationRepository(context));
            _personalNotificationRepository = new Lazy<IPersonalNotificationRepository>(() => new PersonalNotificationRepository(context));
            _cityRepository = new Lazy<ICityRepository>(() => new CityRepository(context));
            _districtRepository = new Lazy<IDistrictRepository>(() => new DistrictRepository(context));
            _neighborhoodRepository = new Lazy<INeighborhoodRepository>(() => new NeighborhoodRepository(context));
        }

        public IPersonalInformationRepository PersonalInformation => _personalInformationRepository.Value;

        public IAppUserRepository AppUser => _appUserRepository.Value;

        public IInquiryFormRepository InquiryForm => _inquiryFormRepository.Value;

        public IRecepientRepository Recepient => _recepientRepository.Value;

        public IDonationRepository Donation => _donationRepository.Value;

        public IDonationMovementRepository DonationMovement => _donationMovementRepository.Value;

        public INotificationRepository Notification => _notificationRepository.Value;

        public IPersonalNotificationRepository PersonalNotification => _personalNotificationRepository.Value;
        public ICityRepository City => _cityRepository.Value;

        public IDistrictRepository District => _districtRepository.Value;

        public INeighborhoodRepository Neighborhood => _neighborhoodRepository.Value;

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
