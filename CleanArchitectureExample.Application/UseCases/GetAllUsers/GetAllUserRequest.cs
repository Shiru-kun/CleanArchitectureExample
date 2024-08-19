using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureExample.Application.UseCases.GetAllUsers
{
    public sealed class GetAllUserRequest:IRequest<List<GetAllUserResponse>>
    {
    }
}
