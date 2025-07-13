﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResumePS.Data.Context;
using ResumePS.Domain.Interfaces;
using ResumePS.Domain.Models.Web;

namespace ResumePS.Data.Repositories
{
    public class WebContactUsRepository :IWebContactUsRepository
    {
        private readonly ResumePSContext context;

        public WebContactUsRepository(ResumePSContext _context)
        {
            context = _context;
        }

        public void Add(WebContactUs webContactUs)
        {
            context.webContactUs.Add(webContactUs);
            
        }

        public void Delete(int id)
        {
            context.webContactUs.Remove(GetById(id));
        }

        public void Delete(WebContactUs webContactUs)
        {
            context.webContactUs.Remove(webContactUs);
        }

        public List<WebContactUs> GetAll()
        {
            return context.webContactUs.ToList();
        }

        //public async Task<FilterAdminContactUsViewModel> GetAllMessage(FilterAdminContactUsViewModel model)
        //{
        //    var query = context.webContactUs.AsQueryable();

        //    await model.Paging(query.Select(p => new AdminContactUsViewModel()
        //    {
        //        CreatedDate = p.CreatedDate,
        //        CreatedDateS = p.CreatedDate.ToShamsi(),
        //        Fullname = p.Fullname,
        //        Message = p.Message,
        //        PhoneNumber = p.PhoneNumber,
        //        Id = p.Id
        //    }));
        //    return model;
        //}

        public WebContactUs GetById(int id)
        {
            return context.webContactUs.Find(id);
        }

        public bool IsExist(int Id)
        {
            return context.webContactUs.Any(p => p.Id == Id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(WebContactUs webContactUs)
        {
            context.webContactUs.Update(webContactUs);
        }
    }
}
