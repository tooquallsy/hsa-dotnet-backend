﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web.Http;

namespace HsaDotnetBackend.Controllers
{
   [RoutePrefix("logintest")]
   [Authorize]
    public class LoginTestController : ApiController
    {
        [Route("test")]
        [HttpGet]
        public IEnumerable<object> Test()
        {
            var identity = User.Identity as ClaimsIdentity;

            var userName = identity.Name;

            return identity.Claims.Select(c => new
            {
                Type = c.Type,
                Value = c.Value
            });
        }
    }
}
