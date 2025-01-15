using System;
using AutoMapper;
using CleanArch.Domain.Entities;

namespace CleanArch.Application.UserCases.CreateUser;

public sealed class CreateUserMapper : Profile
{
    public CreateUserMapper()
    {
        CreateMap<CreateUserRequest, User>();
        CreateMap<User, CreateUserResponse>();
    }
}
