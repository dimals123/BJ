﻿using BJ.DAL.Interfaces;
using BJ.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BJ.DAL.Repositories.EF
{
    public class EFGameRepository : EFGenericRepository<Game, Guid>, IGameRepository
    {
        public EFGameRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}