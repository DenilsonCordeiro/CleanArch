using System;
using AutoMapper;
using CleanArch.Domain.Entities;

namespace CleanArch.Application.UserCases.GetAllUsers;

public sealed class GetAllUsersMapper : Profile
{
    public GetAllUsersMapper()
    {
        CreateMap<User, GetAllUsersResponse>();
    }
}
