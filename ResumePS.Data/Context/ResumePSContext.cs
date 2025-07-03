using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ResumePS.Domain.Models.Auth;

namespace ResumePS.Data.Context
{
    public class ResumePSContext :DbContext
    {
        public ResumePSContext(DbContextOptions<ResumePSContext> options) : base(options)
        {

        }
        public DbSet<User> users { get; set; }
    }
}
