using Entities.Models;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IDistrictRepository : IRepositoryBase<District>
    {
        Task<List<District>> GetDistricts(bool trackChanges);

    }
}
