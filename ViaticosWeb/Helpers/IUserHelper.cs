﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;
using Viaticos.Common.Enums;
using Viaticos.Web.Data.Entities;
using Viaticos.Web.Models;
using ViaticosWeb.Models;

namespace ViaticosWeb.Helpers
{
    public interface IUserHelper
    {
        Task<UserEntity> GetUserAsync(string email);

        Task<UserEntity> GetUserAsync(Guid userId);

        Task<IdentityResult> AddUserAsync(UserEntity user, string password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(UserEntity user, string roleName);

        Task<bool> IsUserInRoleAsync(UserEntity user, string roleName);

        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();
        Task<UserEntity> AddUserAsync(AddUserViewModel model, UserType userType);

        Task<IdentityResult> ChangePasswordAsync(UserEntity user, string oldPassword, string newPassword);

        Task<IdentityResult> UpdateUserAsync(UserEntity user);

    }
}
