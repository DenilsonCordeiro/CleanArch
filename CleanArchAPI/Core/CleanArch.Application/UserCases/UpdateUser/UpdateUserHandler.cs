using System;
using AutoMapper;
using CleanArch.Domain.Interfaces;
using MediatR;

namespace CleanArch.Application.UserCases.UpdateUser;

public class UpdateUserHandler : IRequestHandler<UpdateUserRequest, UpdateUserResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UpdateUserHandler(IUnitOfWork unitOfWork, IUserRepository userRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _userRepository = userRepository;
        _mapper = mapper;
    } 

    public async Task<UpdateUserResponse> Handle(UpdateUserRequest request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.Get(request.Id, cancellationToken);

        if (user == null) return default;

        user.Name = request.Name;
        user.Email = request.Email;

        _userRepository.Update(user);

        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<UpdateUserResponse>(user);
    }
}
