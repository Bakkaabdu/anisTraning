﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anisTraining.Services.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IDriveRepository Drivers { get; }
        IAchievementRepository Achievements { get; }

        Task<bool> CompleteAsync();
    }
}
