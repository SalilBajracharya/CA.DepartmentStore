﻿using CA.DepartmentStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.DepartmentStore.Application.Contracts.Persistence
{
    public interface IRoleRepository : IGenericRepository<Role>
    {
    }
}