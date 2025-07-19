﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ResumePS.Core.Services.Interfaces;
using ResumePS.Domain.Interfaces;
using ResumePS.Domain.Models.Web;

namespace ResumePS.Core.Services.Implementations
{
    public class WebSocialService:IWebSocialService
    {
        private IWebSocialRepository webSocialRepository;
        public WebSocialService(IWebSocialRepository _webSocialRepository)
        {
            webSocialRepository = _webSocialRepository;
        }

     
        public void AddWebsocial(WebSocial webSocial)
        {
            webSocialRepository.Add(webSocial);
            SaveWebSocial();
        }

      
        public void DeleteWebSocial(int id)
        {
            webSocialRepository.Delete(GetWebSocialById(id));
            SaveWebSocial();
        }

        public void DeleteWebSocial(WebSocial webSocial)
        {
            webSocialRepository.Delete(webSocial);
            SaveWebSocial();
        }



        public WebSocial GetWebSocialById(int id)
        {
            return webSocialRepository.GetById(id);
        }

        public List<WebSocial> GetWebSocials()
        {
            return webSocialRepository.GetAll();
        }

        public bool IsExist(int Id)
        {
            return webSocialRepository.IsExist(Id);
        }

        
        public void SaveWebSocial()
        {
            webSocialRepository.Save();
        }

       

        public void UpdateWebSocial(WebSocial webSocial)
        {
            webSocialRepository.Update(webSocial);
            SaveWebSocial();
        }
    }
}
