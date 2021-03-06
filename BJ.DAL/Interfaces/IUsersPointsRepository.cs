﻿using BJ.Entities;
using System;
using System.Threading.Tasks;

namespace BJ.DAL.Interfaces
{
    public interface IUsersPointsRepository : IRepository<UsersPoints, Guid>
    {
        Task<UsersPoints> GetPointsByGameIdAsync(Guid gameId);
    }
}
