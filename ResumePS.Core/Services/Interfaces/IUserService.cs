﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResumePS.Domain.Models.Auth;

namespace ResumePS.Core.Services.Interfaces
{
    public interface IUserService
    {
        User GetUserById(int id);
        List<User> GetUsers();
        bool IsExist(int Id);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
        void DeleteUsers(User user);
        void SaveUser();
    }
}
