﻿using StroyMarket.Dto;
using StroyMarket.Enums;
using StroyMarket.Exceptions;
using StroyMarket.Helpers;
using StroyMarket.Interfaces.Repository;
using StroyMarket.Interfaces.Service;
using StroyMarket.Model;
using System.Net;

namespace StroyMarket.Service
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepo;
        public AuthService(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }
        public bool Create(UserDto request)
        {
            var isUserExist = this._authRepo.GetOne(request.phone);
            if (isUserExist != null) throw new AppException("User already exist", HttpStatusCode.AlreadyReported);

            var user = new User();
            user.first_name = request.firstName;
            user.last_name = request.lastName;
            user.phone = request.phone;
            user.role = Roles.Basic;
            user.password = new PasswordGenerator().Create(request.password);
            user.verification_code = new CodeGeneraor().Generate();
            user.verified = false;

            return this._authRepo.Create(user);
        }

        public bool Verify(string phone, int code)
        {
            var user = _authRepo.GetOne(phone);

            if (user == null)
            {
                throw new AppException("User not found", HttpStatusCode.NotFound);
            }

            if (user.verification_code != code)
            {
                throw new AppException("Incorrect code", HttpStatusCode.BadRequest);
            }
            return this._authRepo.Verify(user.user_id);
        }

        public User Find(string phone)
        {
            var user = _authRepo.GetOne(phone);

            if (user == null)
            {
                throw new AppException("User not found", HttpStatusCode.NotFound);
            }
    
            return user;
        }
    }
}
