﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BJ.DAL.Interfaces;
using BJ.Entities;
using Microsoft.Extensions.Configuration;

namespace BJ.DAL.Repositories.Dapper
{
    public class DapperUserRepository : DapperGenericRepository<User,string>, IUserRepository
    {
        public DapperUserRepository(IConfiguration config) : base(config)
        {
        }

        
    }
}
