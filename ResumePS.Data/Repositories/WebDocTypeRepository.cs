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
    public class WebDocTypeRepository:IWebDocTypeRepository
    {
        private readonly ResumePSContext context;

        public WebDocTypeRepository(ResumePSContext _context)
        {
            context = _context;
        }

        public void Add(WebDocType webDocType)
        {
            context.webDocType.Add(webDocType);
        }

        public void Delete(int id)
        {
            context.webDocType.Remove(GetById(id));
        }

        public void Delete(WebDocType webDocType)
        {
            context.webDocType.Remove(webDocType);

        }

        public List<WebDocType> GetAll()
        {
            return context.webDocType.ToList();
        }

        public WebDocType GetById(int id)
        {
            return context.webDocType.Find(id);
        }

        public bool IsExist(int Id)
        {
            return context.webDocType.Any(d => d.Id == Id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(WebDocType webDocType)
        {
            context.webDocType.Update(webDocType);
        }
    }
}
