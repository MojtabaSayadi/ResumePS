using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using ResumePS.Core.Services.Implementations;
using ResumePS.Core.Services.Interfaces;
using ResumePS.Data.Repositories;
using ResumePS.Domain.Interfaces;

namespace ResumePS.Ioc
{
    public static class DependencyContainer
    {
        public static void  RegisterServices(this IServiceCollection service)
        {

            service.AddScoped<IUserService, UserService>();
            service.AddScoped<IUserRepository, UserRepository>();

           // service.AddScoped<IWebMainInfoRepository, WebMainInfoRepository>();
           // service.AddScoped<IWebMainInfoService, WebMainInfoService>();

        }
    }
}
