using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResumePS.Domain.Models.Web;

namespace ResumePS.Domain.Interfaces
{
    public interface IWebDocTypeRepository
    {
        WebDocType GetById(int id);// find
        bool IsExist(int Id);
        List<WebDocType> GetAll();// select *
        void Add(WebDocType webDocType);// insert
        void Update(WebDocType webDocType);// update
        void Delete(int id);// delete
        void Delete(WebDocType webDocType);
        void Save(); // commit
    }
}
