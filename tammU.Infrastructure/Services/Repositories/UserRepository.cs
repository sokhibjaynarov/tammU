using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tammU.Application.Interfaces.Repositories;
using tammU.Domain.Models;
using tammU.Infrastructure.DbContexts;

namespace tammU.Infrastructure.Services.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
