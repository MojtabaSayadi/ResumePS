using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResumePS.Domain.Models.Web;
using ResumePS.Domain.ViewModels.WebDoc.Client;

namespace ResumePS.Core.Services.Interfaces
{
    public interface IWebDocDetailsRepository
    {
        WebDocDetails GetWebDocDetailsById(int id);
        List<WebDocDetails> GetWebDocDetails();
        List<WebDocDetailsViewModel> GetAllWebDocDetailsViewModel(); /// WebDocDetailsViewModel
        bool IsExist(int Id);
        void AddWebDocDetails(WebDocDetails webDocDetails);
        void UpdateWebDocDetails(WebDocDetails webDocDetails);
        void DeleteWebDocDetails(int id);
        void DeleteWebDocDetails(WebDocDetails webDocDetails);
        void SaveWebDocDetails();
        WebDocDetails GetById(int id);
        void Save();
        void Update(WebDocDetails webDocDetails);
    }
}
