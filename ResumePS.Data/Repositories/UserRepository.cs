using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResumePS.Domain.Interfaces;
using ResumePS.Domain.Models.Auth;
using ResumePS.Data.Context;
namespace ResumePS.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ResumePSContext context;
        public UserRepository(ResumePSContext _context)
        {
            context = _context;
        }
        public void Add(User user)
        {
            context.users.Add(user);
        }

        public void Delete(int id)
        {
            context.users.Remove(GetById(id));
        }

        public void Delete(User user)
        {
            context.users.Remove(user);
        }

        public List<User> GetAll()
        {
            return context.users.ToList();
        }

        public User GetById(int id)
        {
            return context.users.Find(id);
        }

        public bool IsExist(int Id)
        {
            return (context.users.Any(x => x.Id == Id));
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(User user)
        {
            context.users.Update(user);
        }
    }
}
