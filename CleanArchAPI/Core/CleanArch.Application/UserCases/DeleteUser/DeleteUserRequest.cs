using System;
using MediatR;

namespace CleanArch.Application.UserCases.DeleteUser;

public sealed record DeleteUserRequest(Guid Id) : IRequest<DeleteUserResponse>;