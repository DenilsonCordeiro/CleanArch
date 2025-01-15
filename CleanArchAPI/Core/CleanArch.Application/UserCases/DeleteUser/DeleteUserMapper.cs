using System;
using AutoMapper;
using CleanArch.Domain.Entities;

namespace CleanArch.Application.UserCases.DeleteUser;

public sealed class DeleteUserMapper : Profile
{
    public DeleteUserMapper()
    {
        CreateMap<DeleteUserResponse, User>();
        CreateMap<User, DeleteUserResponse>();
    }
}
