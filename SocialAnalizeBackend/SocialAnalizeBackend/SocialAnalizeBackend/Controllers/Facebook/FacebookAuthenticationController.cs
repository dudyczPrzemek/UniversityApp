using GoldenEye.Backend.Core.DDD.Queries;
using Microsoft.AspNetCore.Mvc;
using SA.Contracts.Facebook.User.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA.WebApi.Controllers.Facebook
{
    [Route("api/[controller]")]
    public class FacebookAuthenticationController : Controller
    {
        private readonly IQueryBus queryBus;

        public FacebookAuthenticationController(IQueryBus queryBus)
        {
            this.queryBus = queryBus;
        }

        [HttpGet]
        [Route("authenticate")]
        public ActionResult Get()
        {
            var applicationId = "1578280192264123";
            var redirectUri2 = @"http://localhost:50985/api/facebookAuthentication";
            var redirectUrl = "https://www.facebook.com/v2.10/dialog/oauth?client_id=" + applicationId + "&redirect_uri=" + redirectUri2 + "&scope=user_friends,read_custom_friendlists";
            return Redirect(redirectUrl);
        }

        [HttpGet]
        public ActionResult Get(string code)
        {
            var accessToken =  queryBus.Send<GetFacebookAccessToken, string>(new GetFacebookAccessToken()
            {
                Code = code,
                ApplicationId = "1578280192264123",
                ApplicationSecret = "9993276c6b0cc628133d7c397a178305",
                RedirectUrl = @"http://localhost:50985/api/facebookAuthentication"
            }).Result;

            return Redirect("http://localhost:50985?facebookAccessToken=" + accessToken);
        }

        
    }
}
