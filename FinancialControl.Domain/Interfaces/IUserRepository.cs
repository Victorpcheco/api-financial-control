﻿
using FinancialControl.Domain.Entities;

namespace FinancialControl.Domain.Interfaces
{
    public interface IUserRepository 
    {
        Task<User?> UserExistsAsync(string email);
        Task AddUserAsync(User user);
    }
}
