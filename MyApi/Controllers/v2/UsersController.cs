using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Repositories;
using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using MyApi.Controllers.v1;
using Services;

namespace MyApi.Controllers.v2
{
    /*
    [ApiVersion("2")]
    public class UsersController : v1.UsersController
    {
        public UsersController(IUserRepository userRepository,
            ILogger<v1.UsersController> logger,
            IJwtService jwtService,
            UserManager<User> userManager,
            RoleManager<Role> roleManager,
            SignInManager<User> signInManager)
            : base(userRepository, logger, jwtService, userManager, roleManager, signInManager)
        {
        }
    }
    */
}
