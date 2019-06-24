﻿using Contracts.DTO;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessContracts.Interface.Identity
{
    public interface IAuthRepository
    {
        IdentityUser FindUser(string userName, string password);
    }
}