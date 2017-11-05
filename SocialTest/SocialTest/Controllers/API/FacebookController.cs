using Microsoft.AspNetCore.Mvc;
using SocialTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialTest.Controllers.API
{
    public class FacebookController : Controller
    {
        [HttpGet("api/facebook")]
        public ActionResult Get(string code)
        {
            return InstagramAuthService.GetFaceAuth(code).Result;
        }
    }
}
