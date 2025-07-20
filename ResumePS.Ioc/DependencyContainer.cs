using Microsoft.Extensions.DependencyInjection;
using ResumePS.Core.Services.Implementations;
using ResumePS.Core.Services.Interfaces;
using ResumePS.Data.Repositories;
using ResumePS.Domain.Interfaces;

namespace ResumePS.Ioc
{
    public static class DependencyContainer
    {
        public static void  RegisterServices(this IServiceCollection services)
        {

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<IWebMainInfoRepository, WebMainInfoRepository>();
            services.AddScoped<IWebMainInfoService, WebMainInfoService>();

            services.AddScoped<IWebSocialRepository, WebSocialRepository>();
            services.AddScoped<IWebSocialService, WebSocialService>();

            services.AddScoped<IWebSkillsRepository, WebSkillsRepository>();
            services.AddScoped<IWebSkillsService, WebSkillsService>();

            services.AddScoped<IWebDocTypeRepository, WebDocTypeRepository>();
            services.AddScoped<IWebDocTypeService, WebDocTypeService>();

            services.AddScoped<Domain.Interfaces.IWebDocDetailsRepository, WebDocDetailsRepository>();
            services.AddScoped<IWebDocDetailsService, WebDocDetailsService>();
           
            //services.AddScoped<IWebDocDetailsRepository, WebDocDetailsRepository>();
            //services.AddScoped<IWebDocDetailsService, WebDocDetailsService>();


            services.AddScoped<IWebServicesRepository, WebServicesRepository>();
            services.AddScoped<IWebServicesService, WebServicesService>();

            services.AddScoped<IWebProjectsRepository, WebProjectsRepository>();
            services.AddScoped<IWebProjectsService, WebProjectsService>();

            services.AddScoped<IWebBlogsRepository, WebBlogsRepository>();
            services.AddScoped<IWebBlogsService, WebBlogsService>();

            services.AddScoped<IWebContactUsRepository, WebContactUsRepository>();
            services.AddScoped<IWebContactUsService, WebContactUsService>();

        }
    }
}
