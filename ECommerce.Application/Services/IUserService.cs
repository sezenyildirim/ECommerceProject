﻿using ECommerce.Entity.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Services
{
    public interface IUserService
    {
        Task CreateUser(RegisterDTO registerDTO);
    }
}
