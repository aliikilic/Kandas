using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IDistrictService
    {
        Task<List<GetDistrictsDto>> GetDistrictsAsync(bool trackChanges);
    }
}
