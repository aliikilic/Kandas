using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EfCore
{
    public sealed class AppUserRepository : RepositoryBase<User>, IAppUserRepository
    {
        public AppUserRepository(RepositoryContext context) : base(context)
        {
        }

        public async Task<string> GetUserIdByEmail(string email)
        {
          var entity = await FindByCondition(x => x.UserName.Equals(email), false).SingleOrDefaultAsync();
            return entity.Id.ToString();
        }

    }
}
