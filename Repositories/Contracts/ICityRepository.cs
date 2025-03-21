﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface ICityRepository : IRepositoryBase<City>
    {
        Task<List<City>> GetCities(bool trackChanges);
    }
}
