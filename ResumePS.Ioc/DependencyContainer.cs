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

            service.AddScoped<IWebMainInfoRepository, WebMainInfoRepository>();
            service.AddScoped<IWebMainInfoService, WebMainInfoService>();

            //service.AddScoped<IWebSocialRepository, WebSocialRepository>();
            //service.AddScoped<IWebSocialService, WebSocialService>();

            //service.AddScoped<IWebSkillsRepository, WebSkillsRepository>();
            //service.AddScoped<IWebSkillsService, WebSkillsService>();

            //service.AddScoped<IWebDocTypeRepository, WebDocTypeRepository>();
            //service.AddScoped<IWebDocTypeService, WebDocTypeService>();

            //service.AddScoped<IWebDocDetailsRepository, WebDocDetailsRepository>();
            //service.AddScoped<IWebDocDetailsService, WebDocDetailsService>();


            //service.AddScoped<IWebServicesRepository, WebServicesRepository>();
            //service.AddScoped<IWebServicesService, WebServicesService>();

            //service.AddScoped<IWebProjectsRepository, WebProjectsRepository>();
            //service.AddScoped<IWebProjectsService, WebProjectsService>();

            //service.AddScoped<IWebBlogsRepository, WebBlogsRepository>();
            //service.AddScoped<IWebBlogsService, WebBlogsService>();

            service.AddScoped<IWebContactUsRepository, WebContactUsRepository>();
            service.AddScoped<IWebContactUsService, WebContactUsService>();

        }
    }
}
