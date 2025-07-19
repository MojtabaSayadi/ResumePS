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
    public class WebSkillsService : IWebSkillsService
    {
        private IWebSkillsRepository webSkillsRepository;
        public WebSkillsService(IWebSkillsRepository _webSkillsRepository)
        {
            webSkillsRepository = _webSkillsRepository;
        }

        public void AddWebSkills(WebSkills webSkills)
        {
            webSkillsRepository.Add(webSkills);
            SaveWebSkills();
        }

        public void DeleteWebSkills(int id)
        {
            webSkillsRepository.Delete(GetWebSkillsById(id));
            SaveWebSkills();
        }

        public void DeleteWebSkills(WebSkills webSkills)
        {
            webSkillsRepository.Delete(webSkills);
            SaveWebSkills();
        }

        public List<WebSkills> GetWebSkills()
        {
            return webSkillsRepository.GetAll();
        }

        public WebSkills GetWebSkillsById(int id)
        {
            return webSkillsRepository.GetById(id);
        }

        public bool IsExist(int Id)
        {
            return webSkillsRepository.IsExist(Id);
        }

        public void SaveWebSkills()
        {
            webSkillsRepository.Save();
        }

        public void UpdateWebSkills(WebSkills webSkills)
        {
            webSkillsRepository.Update(webSkills);
            SaveWebSkills();
        }
    }
}
