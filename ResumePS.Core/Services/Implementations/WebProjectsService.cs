using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResumePS.Core.Services.Interfaces;
using ResumePS.Domain.Interfaces;
using ResumePS.Domain.Models.Web;

namespace ResumePS.Core.Services.Implementations
{
    public class WebProjectsService:IWebProjectsService
    {
        private IWebProjectsRepository webProjectsRepository;
        public WebProjectsService(IWebProjectsRepository _webProjectsRepository)
        {
            webProjectsRepository = _webProjectsRepository;
        }

        public void AddWebProjects(WebProjects webProjects)
        {
            webProjectsRepository.Add(webProjects);
        }

        public void DeleteWebProjects(int id)
        {
            webProjectsRepository.Delete(GetWebProjectsById(id));
            SaveWebProjects();
        }

        public void DeleteWebProjects(WebProjects webProjects)
        {
            webProjectsRepository.Delete(webProjects);
            SaveWebProjects();
        }

        public List<WebProjects> GetWebProjects()
        {
            return webProjectsRepository.GetAll();
        }

        public WebProjects GetWebProjectsById(int id)
        {
            return webProjectsRepository.GetById(id);
        }

        public bool IsExist(int Id)
        {
            return webProjectsRepository.IsExist(Id);
        }

        public void SaveWebProjects()
        {
            webProjectsRepository.Save();
        }

        public void UpdateWebProjects(WebProjects webProjects)
        {
            webProjectsRepository.Update(webProjects);
            SaveWebProjects();
        }
    }
}
