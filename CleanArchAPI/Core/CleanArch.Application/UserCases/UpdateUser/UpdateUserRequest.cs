using System;
using MediatR;

namespace CleanArch.Application.UserCases.UpdateUser;


public sealed record UpdateUserRequest(Guid Id, String Email, String Name) : IRequest<UpdateUserResponse>;