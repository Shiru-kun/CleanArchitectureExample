﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureExample.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        void Commit();  
    }
}
