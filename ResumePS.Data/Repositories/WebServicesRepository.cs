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
    public class WebServicesRepository:IWebServicesRepository
    {
        private readonly ResumePSContext context;

        public WebServicesRepository(ResumePSContext _context)
        {
            context = _context;
        }
        public void Add(WebServices webServices)
        {
            context.webServices.Add(webServices);
        }

        public void Delete(int id)
        {
            context.webServices.Remove(GetById(id));
        }

        public void Delete(WebServices webServices)
        {
            context?.webServices.Remove(webServices);
        }

        public List<WebServices> GetAll()
        {
            return context.webServices.ToList();
        }

        public WebServices GetById(int id)
        {
            return context.webServices.Find(id);
        }

        public bool IsExist(int Id)
        {
            return context.webServices.Any(x => x.Id == Id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(WebServices webServices)
        {
            context.webServices.UpdateRange(webServices);
        }
    }
}
