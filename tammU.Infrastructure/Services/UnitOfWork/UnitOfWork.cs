using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tammU.Application.Interfaces.Repositories;
using tammU.Application.Interfaces.UnitOfWork;
using tammU.Infrastructure.DbContexts;
using tammU.Infrastructure.Services.Repositories;

namespace tammU.Infrastructure.Services.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext context;
        private readonly IConfiguration config;

        /// <summary>
        /// Repositories
        /// </summary>
        public IUserRepository Users { get; private set; }


        public UnitOfWork(AppDbContext context, IConfiguration config)
        {
            this.context = context;
            this.config = config;

            // Object initializing for repositories
            Users = new UserRepository(context);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
