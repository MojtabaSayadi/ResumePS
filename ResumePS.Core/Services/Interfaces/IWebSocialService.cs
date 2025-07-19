using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResumePS.Domain.Models.Web;

namespace ResumePS.Core.Services.Interfaces
{
    public interface IWebSocialService
    {
        WebSocial GetWebSocialById(int id);
        List<WebSocial> GetWebSocials();
        bool IsExist(int Id);
        void AddWebsocial(WebSocial webSocial);
        void UpdateWebSocial(WebSocial webSocial);
        void DeleteWebSocial(int id);
        void DeleteWebSocial(WebSocial webSocial);
        void SaveWebSocial();

    }
}
