using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureExample.Application.UseCases.CreateUser
{
    public sealed class CreateUserRequest: IRequest<CreateUserResponse>
    {
        public string Email { get; set; } = string.Empty;

    }
}
