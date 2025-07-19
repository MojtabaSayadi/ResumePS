using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResumePS.Core.Services.Interfaces;
using ResumePS.Domain.Models.Web;
using ResumePS.Domain.ViewModels.WebDoc.Client;

namespace ResumePS.Core.Services.Implementations
{
    public class WebDocDetailsService:IWebDocDetailsService
    {
        private readonly IWebDocDetailsRepository webDocDetailsRepository;
       private IWebDocTypeService webDocTypeService;

        public WebDocDetailsService(IWebDocTypeService _webDocTypeService, IWebDocDetailsRepository _webDocDetailsRepository)
        {
            webDocDetailsRepository = _webDocDetailsRepository;
            webDocTypeService = _webDocTypeService;
        }

        public void AddWebDocDetails(WebDocDetails webDocDetails)
        {
            webDocDetailsRepository.AddWebDocDetails(webDocDetails);//Add(webDocDetails);
            SaveWebDocDetails();
        }

        public void DeleteWebDocDetails(int id)
        {
            webDocDetailsRepository.DeleteWebDocDetails(GetWebDocDetailsById(id));
            SaveWebDocDetails();
        }

        public void DeleteWebDocDetails(WebDocDetails webDocDetails)
        {
            webDocDetailsRepository.DeleteWebDocDetails(webDocDetails);
            SaveWebDocDetails();
        }

        public List<WebDocDetailsViewModel> GetAllWebDocDetailsViewModel()
        {
            List<WebDocDetails> webDocDetails = webDocDetailsRepository.GetWebDocDetails ();//kham

            List<WebDocDetailsViewModel> result = new List<WebDocDetailsViewModel>();
            WebDocDetailsViewModel tmp = new WebDocDetailsViewModel();

            foreach (var item in webDocDetails)
            {
                tmp = new WebDocDetailsViewModel()
                {
                    Title = item.Title,
                    ImageName = item.Image,
                    Title_En = webDocTypeService.GetWebDocTypeById(item.TypeId).Title_En
                };

                result.Add(tmp);
            }

            return result;


        }

        public List<WebDocDetails> GetWebDocDetails()
        {
            return webDocDetailsRepository.GetWebDocDetails();
        }

        public WebDocDetails GetWebDocDetailsById(int id)
        {
            return webDocDetailsRepository.GetById(id);
        }

        public bool IsExist(int Id)
        {
            return webDocDetailsRepository.IsExist(Id);
        }

        public void SaveWebDocDetails()
        {
            webDocDetailsRepository.Save();
        }

        public void UpdateWebDocDetails(WebDocDetails webDocDetails)
        {
            webDocDetailsRepository.Update(webDocDetails);
            SaveWebDocDetails();
        }

    }
}
