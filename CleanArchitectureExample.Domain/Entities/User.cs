using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureExample.Domain.Entities
{
    public sealed class User: Entity
    {
        public string Email { get; set; } = string.Empty;
    }
}
