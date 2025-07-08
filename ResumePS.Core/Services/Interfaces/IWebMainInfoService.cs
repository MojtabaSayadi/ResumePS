using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResumePS.Domain.Models.Web;
using ResumePS.Domain.ViewModels;

namespace ResumePS.Core.Services.Interfaces
{
    public interface IWebMainInfoService
    {
        WebMainInfo GetWebById(int id);

        MyInfoOnWebViewModel GetWebInfoViewModel();

        List<WebMainInfo> GetWebs();
        bool IsExist(int Id);
        void AddWeb(WebMainInfo webMainInfo);
        void UpdateWeb(WebMainInfo webMainInfo);
        void DeleteWeb(int id);
        void DeleteWebs(WebMainInfo webMainInfo);
        void SaveWeb();
    }
}
