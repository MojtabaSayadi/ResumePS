using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResumePS.Data.Context;
using ResumePS.Domain.Interfaces;
using ResumePS.Domain.Models.Web;

namespace ResumePS.Data.Repositories
{
    public class WebSkillsRepository:IWebSkillsRepository
    {
        private readonly ResumePSContext context;

        public WebSkillsRepository(ResumePSContext _context)
        {
            context = _context;
        }

        public void Add(WebSkills webSkills)
        {
            context.webSkills.Add(webSkills);
        }

        public void Delete(int id)
        {
            context.webSkills.Remove(GetById(id));
        }

        public void Delete(WebSkills webSkills)
        {
            context.webSkills.Remove(webSkills);
        }

        public List<WebSkills> GetAll()
        {
            return context.webSkills.ToList();
        }

        public WebSkills GetById(int id)
        {
            return context.webSkills.Find(id);
        }

        public bool IsExist(int Id)
        {
            return context.webSkills.Any(x => x.Id == Id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(WebSkills webSkills)
        {
            context.Update(webSkills);
        }
    }
}
