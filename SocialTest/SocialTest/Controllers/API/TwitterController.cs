using Microsoft.AspNetCore.Mvc;
using SocialTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Models;

namespace SocialTest.Controllers.API
{
    public class TwitterController : Controller
    {
        
        public ActionResult Get(string authorization_id, string oauth_token, string oauth_verifier)
        {
            return InstagramAuthService.GetTwitterAuth(oauth_verifier).Result;
        }
    }
}
