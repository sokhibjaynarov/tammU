using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using tammU.Application.Interfaces.Services;
using tammU.Application.Interfaces.UnitOfWork;
using tammU.Infrastructure.DbContexts;
using tammU.Infrastructure.Services.Services;
using tammU.Infrastructure.Services.UnitOfWork;

namespace tammU.Desktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        private readonly IHost host;
        public App()
        {
            host = new HostBuilder().ConfigureServices((hostContext, services) =>
            {
                services.AddScoped<IUnitOfWork, UnitOfWork>();
                services.AddScoped<IUserService, UserService>();
                
            }).Build();
        }

        
    }
}
