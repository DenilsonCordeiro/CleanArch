using System;
using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Interfaces;


public interface IUserRepository : IBaseRepository<User>
{
    Task<User> GetByEmail(string email, CancellationToken cancellationToken);
}

