﻿using System;
using to_do_api.DAOs.@abstract;
using to_do_api.Models;
namespace to_do_api.DAOs
{
    public interface IUserDAO : IAbstractCreateReadUpdateDAO<User>
    {
        User GetUserByEmail(string email);
    }
}
