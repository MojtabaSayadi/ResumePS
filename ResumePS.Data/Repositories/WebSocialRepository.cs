using ResumePS.Domain.Models.Web;
using ResumePS.Data.Context;
using ResumePS.Domain.Interfaces;

namespace ResumePS.Data.Repositories
{
    public class WebSocialRepository:IWebSocialRepository
    {
        private readonly ResumePSContext context;

        public WebSocialRepository(ResumePSContext _context)
        {
            context = _context;
        }
        public void Add(WebSocial webSocial)
        {
            context.Add(webSocial);
        }

        
        public void Delete(int id)
        {
            context.webSocials.Remove(GetById(id));
        }

        public void Delete(WebSocial webSocial)
        {
            context.webSocials.Remove(webSocial);
        }

              public List<WebSocial> GetAll()
        {
            return context.webSocials.ToList();
        }

        public WebSocial GetById(int id)
        {
            return context.webSocials.Find(id);
        }

        public bool IsExist(int Id)
        {
            return context.webSocials.Any(s => s.Id == Id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(WebSocial webSocial)
        {
            context.Update(webSocial);
        }

       
    }
}
