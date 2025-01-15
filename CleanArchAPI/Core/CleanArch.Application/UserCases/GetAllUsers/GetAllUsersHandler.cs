using System;
using AutoMapper;
using CleanArch.Domain.Interfaces;
using MediatR;

namespace CleanArch.Application.UserCases.GetAllUsers;

public class GetAllUsersHandler : IRequestHandler<GetAllUsersRequest, List<GetAllUsersResponse>>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public GetAllUsersHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }
    public async Task<List<GetAllUsersResponse>> Handle(GetAllUsersRequest request, CancellationToken cancellationToken)
    {
        var users = await _userRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllUsersResponse>>(users);
    }
}
