﻿using NawafizApp.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NawafizApp.Services.Interfaces
{
    public interface IUserService
    {
        Guid Add(UserDto dto);
        bool Edit(UserDto dto);
        bool Delete(Guid id);
        UserDto GetById(Guid id);
        List<UserDto> GetAll();
        bool HasRole(Guid id, String role);
        List<UserDto> GetUsersByRole(string role);
        bool Exists(Guid id);
        bool IsEmailUnique(string email);
    }
}
