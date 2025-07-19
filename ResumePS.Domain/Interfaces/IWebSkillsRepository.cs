using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResumePS.Domain.Models.Web;

namespace ResumePS.Domain.Interfaces
{
    public interface IWebSkillsRepository
    {
        WebSkills GetById(int id);// find
        bool IsExist(int Id);
        List<WebSkills> GetAll();// select *
        void Add(WebSkills webSkills);// insert
        void Update(WebSkills webSkills);// update
        void Delete(int id);// delete
        void Delete(WebSkills webSkills);
        void Save(); // commit
    }
}
