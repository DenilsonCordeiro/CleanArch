using System;

namespace CleanArch.Application.UserCases.GetAllUsers;

public sealed record GetAllUsersResponse 
{
    public Guid Id { get; set; }
    public string? Email { get; set; }
    public string? Name { get; set; }
}
