using AutoMapper;
using Entities.Dtos;
using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CityManager : ICityService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public CityManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<List<GetCitiesDto>> GetCities(bool trackChanges)
        {
            var list = await _repositoryManager.City.GetCities(trackChanges);
            var mappedList = _mapper.Map<List<GetCitiesDto>>(list);

            return mappedList;



        }
    }
}
