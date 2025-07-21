using System.Diagnostics;
using IPE.SmsIrClient.Models.Requests;
using IPE.SmsIrClient.Models.Results;
using IPE.SmsIrClient;
using Microsoft.AspNetCore.Mvc;
using ResumePS.Core.Services.Interfaces;
using ResumePS.Domain.ViewModels;
using ResumePS.Models;
using ResumePS.Domain.Models.Web;
using ResumePS.Domain.ViewModels.WebDoc.ContactUs.Client;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using ResumePS.Domain.ViewModels.WebDoc.Client;


namespace ResumePS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IWebMainInfoService webMainInfoService;
        private IWebSkillsService webSkillsService;
        private IWebSocialService webSocialService;
        private IWebDocTypeService webDocTypeService;
        private IWebDocDetailsService webDocDetailsService;
        private IWebServicesService webServicesService;
        private IWebProjectsService webProjectsService;
        private IWebBlogsService webBlogsService;
        private IWebContactUsService webContactUsService;
        //public IRecaptchaService recaptchaService { get; set; }
        public IConfiguration configuration;

       public HomeController(
           IWebDocDetailsService _webDocDetailsService, IWebDocTypeService _webDocTypeService,
            IWebServicesService _webServicesService, IWebProjectsService _webProjectsService,
         IWebSkillsService _webSkillsService, IWebSocialService _webSocialService, 
        IWebMainInfoService _webMainInfoService,
        IWebBlogsService _webBlogsService,
        ILogger<HomeController> logger,
        IWebContactUsService _webContactUsService,
        //IRecaptchaService _recaptchaService,
        IConfiguration _configuration)



        {
            _logger = logger;
            webMainInfoService = _webMainInfoService;
            webSocialService = _webSocialService;
            webSkillsService = _webSkillsService;
            webDocTypeService = _webDocTypeService;
            webDocDetailsService = _webDocDetailsService;
            webServicesService = _webServicesService;
            webProjectsService = _webProjectsService;
            webBlogsService = _webBlogsService;
            webContactUsService = _webContactUsService;
            //recaptchaService = _recaptchaService;
            configuration = _configuration;

        }

        [HttpGet]
        public IActionResult Index(string? message, string? errmessage)
        {
            if (!string.IsNullOrEmpty(message))
                ViewBag.Message = message;

            if (!string.IsNullOrEmpty(errmessage))
                ViewBag.errmessage = errmessage;

            MyInfoOnWebViewModel myinfo = webMainInfoService.GetWebInfoViewModel();
            ViewBag.WebInfo = myinfo;

            List<WebDocViewModel> list = webDocTypeService.GetAllWebDocTypeViewModel();
            ViewBag.WebDoc = list;



            List<WebSocial> MySocial = webSocialService.GetWebSocials();
            ViewBag.Social = MySocial;

            List<WebServices> MyServices = webServicesService.GetWebServices();
            ViewBag.Services = MyServices;


            List<WebBlogs> webBlogs = webBlogsService.GetWebBlogs();
            ViewBag.Blogs = webBlogs;

            List<WebSkills> MySkills = webSkillsService.GetWebSkills();
            ViewBag.Skills = MySkills;

            List<WebDocDetailsViewModel> docDetailsViewModels = webDocDetailsService.GetAllWebDocDetailsViewModel();
            ViewBag.DocD = docDetailsViewModels;
            #region calculate of experience
            int startYear = 1996;
            int currentYear = DateTime.Now.Year;

            int yearsOfExperience = currentYear - startYear;
            ViewBag.exp_year = yearsOfExperience;
            #endregion
            List<WebProjects> MyProject = webProjectsService.GetWebProjects();
            ViewBag.MyProjects = MyProject;



            #region GoogleRecapcha
            //GoogleRecapchaForViewViewModel tmp = new GoogleRecapchaForViewViewModel()
            //{
            //    SiteKey = GoogleRecapchaViewModel.SiteKey
            //};

            //ViewData["SiteKey"] = tmp;
            #endregion


            //return View(new WebContactUsViewModel());
            return View();
        }


        [HttpPost]
        public IActionResult Index(WebContactUsViewModel model)
        {
           // #region InitViewBags
            MyInfoOnWebViewModel myinfo = webMainInfoService.GetWebInfoViewModel();
            ViewBag.WebInfo = myinfo;


            #region calculate of experience
            int startYear = 1996;
            int currentYear = DateTime.Now.Year;

            int yearsOfExperience = currentYear - startYear;
            ViewBag.exp_year = yearsOfExperience;
            #endregion

            if (ModelState.IsValid)
            {
                bool isPhoneNumber = true;
                foreach (var item in model.PhoneNumber)
                {
                    isPhoneNumber = int.TryParse(item.ToString(), out int result);
                    if (isPhoneNumber == false)
                        break;
                }
                if (isPhoneNumber)
                {

                    WebContactUs webContactUs = new WebContactUs()
                    {
                        CreatedDate = DateTime.Now,
                        Fullname = model.Fullname,
                        Message = model.Message,
                        PhoneNumber = model.PhoneNumber,
                    };
                    webContactUsService.AddWebContactUs(webContactUs);
                    //return View(new WebContactUsViewModel());
                    return View(); 
                }

                else
                {
                    ModelState.AddModelError("PhoneNumber", "فرمت وارد شده صحیح نمی باشد.");
                }

            }
            else
            {
                ModelState.AddModelError("PhoneNumber", "فرمت وارد شده صحیح نمی باشد.");

            }
        return View(model);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
