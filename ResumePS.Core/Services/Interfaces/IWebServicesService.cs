using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResumePS.Domain.Models.Web;

namespace ResumePS.Core.Services.Interfaces
{
    public interface IWebServicesService
    {
        WebServices GetWebServicesById(int id);
        List<WebServices> GetWebServices();
        bool IsExist(int Id);
        void AddWebServices(WebServices webServices);
        void UpdateWebServices(WebServices webServices);
        void DeleteWebServices(int id);
        void DeleteWebServices(WebServices webServices);
        void SaveWebServices();

    }
}
