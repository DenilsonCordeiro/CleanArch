using System;
using FluentValidation;

namespace CleanArch.Application.UserCases.GetAllUsers;

public sealed class GetAllUsersValidator : AbstractValidator<GetAllUsersRequest>
{
    public GetAllUsersValidator()
    {
    }
}
