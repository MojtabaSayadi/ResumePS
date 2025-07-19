using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResumePS.Domain.Models.Web;
using ResumePS.Domain.ViewModels.WebDoc;
using ResumePS.Domain.ViewModels.WebDoc.Client;
namespace ResumePS.Core.Services.Interfaces
{
    public interface IWebDocTypeService
    {
        WebDocType GetWebDocTypeById(int id);
        List<WebDocType> GetWebDocType();
        List<WebDocViewModel> GetAllWebDocTypeViewModel();
        bool IsExist(int Id);
        void AddWebDocType(WebDocType webDocType);
        void UpdateWebDocType(WebDocType webDocType);
        void DeleteWebDocType(int id);
        void DeleteWebDocType(WebDocType webDocType);
        void SaveWebDocType();
    }
}
