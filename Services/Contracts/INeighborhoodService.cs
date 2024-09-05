using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface INeighborhoodService
    {
        Task<List<GetNeighborhoodsDto>> GetNeighborhoods(bool trackChanges);
    }
}
