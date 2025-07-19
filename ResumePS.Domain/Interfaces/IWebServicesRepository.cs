using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResumePS.Domain.Models.Web;

namespace ResumePS.Domain.Interfaces
{
    public interface IWebServicesRepository
    {
        WebServices GetById(int id);// find
        bool IsExist(int Id);
        List<WebServices> GetAll();// select *
        void Add(WebServices webServices);// insert
        void Update(WebServices webServices);// update
        void Delete(int id);// delete
        void Delete(WebServices webServices);
        void Save(); // commit
    }
}
