using System;
using System.Data;
using FluentValidation;

namespace CleanArch.Application.UserCases.DeleteUser;

public class DeleteUserValidator : AbstractValidator<DeleteUserRequest>
{
    public DeleteUserValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}
