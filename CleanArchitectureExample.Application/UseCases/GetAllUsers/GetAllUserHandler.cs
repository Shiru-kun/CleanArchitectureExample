using AutoMapper;
using CleanArchitectureExample.Domain.Entities;
using CleanArchitectureExample.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureExample.Application.UseCases.GetAllUsers
{
    public sealed class GetAllUserHandler :IRequestHandler<GetAllUserRequest, List<GetAllUserResponse>>   
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public GetAllUserHandler(IUserService userService, IMapper mapper) { 
            _userService = userService; 
            _mapper = mapper;
        }

        public async Task<List<GetAllUserResponse>> Handle(GetAllUserRequest request, CancellationToken cancellationToken)
        {
            List<User> users = await _userService.GetAll();
            return _mapper.Map<List<GetAllUserResponse>>(users);    

        }
    }
}
