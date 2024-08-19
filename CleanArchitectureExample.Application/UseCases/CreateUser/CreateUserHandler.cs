using AutoMapper;
using CleanArchitectureExample.Domain.Entities;
using CleanArchitectureExample.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureExample.Application.UseCases.CreateUser
{
    public sealed class CreateUserHandler : IRequestHandler<CreateUserRequest, CreateUserResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public CreateUserHandler(IUnitOfWork unitOfWork,IUserService userService, IMapper mapper ) { 
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _userService = userService;
        }
        public async Task<CreateUserResponse> Handle(CreateUserRequest request, CancellationToken cancellationToken)
        {
            await Task.Delay(100);
            var user = _mapper.Map<User>(request);
            _userService.CreateUser(user);
            _unitOfWork.Commit();
            return _mapper.Map<CreateUserResponse>(user);
        }
    }
}
