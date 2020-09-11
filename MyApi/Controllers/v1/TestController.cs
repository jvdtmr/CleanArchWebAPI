using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFramework.Filters;

namespace MyApi.Controllers.v1
{
    [ApiController]
    [AllowAnonymous]
    [ApiResultFilter]
    //[ApiVersion("1")]
    //[Route("api/v{version:apiVersion}/[controller]")]// api/v1/test
    [Route("api/[controller]")]// api/test?api-version=1
    public class TestController : ControllerBase
    {
        public string Get()
        {
            return "Test";
        }
    }
}
