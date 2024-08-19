using AutoMapper;
using CleanArchitectureExample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureExample.Application.UseCases.GetAllUsers
{
    public sealed class GetAllUserMapper : Profile
    {
        public GetAllUserMapper() {

            CreateMap<User, GetAllUserResponse>(); 
        }   
    }
}
