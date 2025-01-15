using System;
using MediatR;

namespace CleanArch.Application.UserCases.GetAllUsers;

public sealed record GetAllUsersRequest : IRequest<List<GetAllUsersResponse>>;
