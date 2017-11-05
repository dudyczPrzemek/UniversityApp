using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SocialTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SocialTest.Controllers
{
    public class InstagramController : Controller
    {
        [HttpGet("api/instagram")]
        public ActionResult Get(string code)
        {
            return InstagramAuthService.GetInstaAuth(code).Result;
        }
    }
}
