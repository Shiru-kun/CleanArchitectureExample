﻿using CleanArchitectureExample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureExample.Persistance
{
    public class UserContext
    {
        public List<User> Users { get; set; } = new List<User>();
    }
}
