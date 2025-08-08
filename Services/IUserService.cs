﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpendWise.Models;

namespace SpendWise.Services
{
    public interface IUserService
    {
        Task SaveUserAsync(User user);

        Task<List<User>> LoadUsersAsync();
    }
}