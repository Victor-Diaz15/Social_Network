﻿using Social_Network.Core.Application.Helpers;
using Social_Network.Core.Application.ViewModels.User;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Social_Network.Middlewares
{
    public class ValidateUserSession
    {
        public readonly IHttpContextAccessor _httpContextAccessor;

        public ValidateUserSession(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public bool HasUser()
        {
            UserViewModel userVm = _httpContextAccessor.HttpContext.Session.Get<UserViewModel>("user");
            bool validate = userVm == null ? false : true;
            return validate;
        }
    }
}
