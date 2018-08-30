﻿using RaceManager.Server.DataAccess.Core.Domain;
using RaceManager.Server.Service.Core.DataMappers;
using RaceManager.Server.Service.Core.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaceManager.Server.Service.DataMappers
{
    class UserMapper : DataMapper<User, UserDTO>, IUserMapper
    {
        public static UserMapper Instance { get; } = new UserMapper();

        static UserMapper() { }

        private UserMapper() { }

        public override User Map(UserDTO userDTO)
        {
            var user = new User();

            if (userDTO != null)
            {
                user.Id = userDTO.Id;
                user.Username = userDTO.Username;
                user.Password = userDTO.Password;
                user.FirstName = userDTO.FirstName;
                user.LastName = userDTO.LastName;
                user.SecurityToken = userDTO.SecurityToken;
                user.IsAdmin = userDTO.IsAdmin;
            }

            return user;
        }

        public override UserDTO Map(User user)
        {
            var userDTO = new UserDTO();

            if (user != null)
            {
                userDTO.Id = user.Id;
                userDTO.Username = user.Username;
                userDTO.Password = user.Password;
                userDTO.FirstName = user.FirstName;
                userDTO.LastName = user.LastName;
                userDTO.SecurityToken = user.SecurityToken;
                userDTO.IsAdmin = user.IsAdmin;
            }

            return userDTO;
        }
    }
}