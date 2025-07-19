using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResumePS.Data.Context;
using ResumePS.Domain.Models.Web;

namespace ResumePS.Data.Repositories
{
    public class WebProjectsRepository
    {
        private readonly ResumePSContext context;

        public WebProjectsRepository(ResumePSContext _context)
        {
            context = _context;
        }

        public void Add(WebProjects webProjects)
        {
            context.webProjects.Add(webProjects);
        }

        public void Delete(int id)
        {
            context.webProjects.Remove(GetById(id));
        }

        public void Delete(WebProjects webProjects)
        {
            context.webProjects.Remove(webProjects);
        }

        public List<WebProjects> GetAll()
        {
            return context.webProjects.ToList();
        }

        public WebProjects GetById(int id)
        {
            return context.webProjects.Find(id);
        }

        public bool IsExist(int Id)
        {
            return (context.webProjects.Any(p => p.Id == Id));
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(WebProjects webProjects)
        {
            context.webProjects.Update(webProjects);
        }
    }
}
