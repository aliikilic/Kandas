using AutoMapper;
using Entities.Dtos;
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
    public class DistrictManager : IDistrictService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public DistrictManager(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<List<GetDistrictsDto>> GetDistrictsAsync(bool trackChanges)
        {
            var list = await _manager.District.GetDistricts(trackChanges);
            var mappedList = _mapper.Map<List<GetDistrictsDto>>(list);

            return mappedList;
        }
    }
}
