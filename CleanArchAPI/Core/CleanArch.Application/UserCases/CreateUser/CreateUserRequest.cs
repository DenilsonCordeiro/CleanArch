using MediatR;

namespace CleanArch.Application.UserCases.CreateUser;

public sealed record CreateUserRequest(string Email, string Name) : IRequest<CreateUserResponse>;
