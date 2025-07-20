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
    public class WebDocDetailsRepository:IWebDocDetailsRepository
    {
        private readonly ResumePSContext context;

        public WebDocDetailsRepository(ResumePSContext _context)
        {
            context = _context;
        }
        public void Add(WebDocDetails webDocDetails)
        {
            context.webDocDetails.Add(webDocDetails);
        }

        public void Delete(int id)
        {
            context.webDocDetails.Remove(GetById(id));
        }

        public void Delete(WebDocDetails webDocDetails)
        {
            context.webDocDetails.Remove(webDocDetails);
        }

        public List<WebDocDetails> GetAll()
        {
            return context.webDocDetails.ToList();
        }

        public WebDocDetails GetById(int id)
        {
            return context.webDocDetails.Find(id);
        }

        public bool IsExist(int Id)
        {
            return context.webDocDetails.Any(x => x.Id == Id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(WebDocDetails webDocDetails)
        {
            context.webDocDetails.Update(webDocDetails);
        }

    }
}
