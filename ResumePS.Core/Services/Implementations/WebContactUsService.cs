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
    public class WebContactUsService:IWebContactUsService
    {
        public IWebContactUsRepository webContactUsRepository { get; set; }

        public WebContactUsService(IWebContactUsRepository _webContactUsRepository)
        {
            webContactUsRepository = _webContactUsRepository;
        }

        public void AddWebContactUs(WebContactUs webContactUs)
        {
            webContactUsRepository.Add(webContactUs);
            SaveWebContactUs();

        }

        public void DeleteWebContactUs(int id)
        {
            webContactUsRepository.Delete(id);
            SaveWebContactUs();

        }

        public void DeleteWebContactUss(WebContactUs webContactUs)
        {
            webContactUsRepository.Delete(webContactUs);
            SaveWebContactUs();

        }

        public WebContactUs GetWebContactUsById(int id)
        {
            return webContactUsRepository.GetById(id);
        }

        public List<WebContactUs> GetWebContactUss()
        {
            return webContactUsRepository.GetAll();
        }

        public bool IsExist(int Id)
        {
            return webContactUsRepository.IsExist(Id);
        }

        public void SaveWebContactUs()
        {
            webContactUsRepository.Save();
        }

        public void UpdateWebContactUs(WebContactUs webContactUs)
        {
            webContactUsRepository.Update(webContactUs);
            SaveWebContactUs();
        }

    }
}
