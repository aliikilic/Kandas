using AutoMapper;
using Entities.Dtos;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class NeighborhoodManager : INeighborhoodService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public NeighborhoodManager(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<List<GetNeighborhoodsDto>> GetNeighborhoods(bool trackChanges)
        {
            var list = await _manager.Neighborhood.GetNeighborhoods(trackChanges);
            var mappedList = _mapper.Map<List<GetNeighborhoodsDto>>(list);

            return mappedList;
        }
    }
}
