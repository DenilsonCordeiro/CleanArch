using System;
using AutoMapper;
using CleanArch.Domain.Entities;

namespace CleanArch.Application.UserCases.UpdateUser;

public sealed class UpdateUserMapper : Profile
{
    public UpdateUserMapper()
    {
        CreateMap<UpdateUserResponse, User>();
        CreateMap<User, UpdateUserResponse>();
    }
}
