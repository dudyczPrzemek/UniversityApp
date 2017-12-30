using GoldenEye.Backend.Core.DDD.Queries;
using Microsoft.AspNetCore.Mvc;
using SA.Contracts.Twitter.User.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Models;

namespace SA.WebApi.Controllers.Twitter
{
    [Route("api/[controller]")]
    public class TwitterAuthenticationController : Controller
    {
        private readonly IQueryBus queryBus;

        public TwitterAuthenticationController(IQueryBus queryBus)
        {
            this.queryBus = queryBus;
        }

        [HttpGet]
        [Route("authenticate")]
        public ActionResult Get()
        {
            var redirectUrl = @"http://localhost:50985/api/twitterAuthentication";
            var consKey = "WdraGJz5UUR2l8Y35g9zBrwOw";
            var consSecret = "oxurh7hr5HxkCUChNwnshmCjNjOhdhE5r307AOEhZtxYKbPbyd";
            var apsCred = new ConsumerCredentials(consKey, consSecret);
            var authenticationContext = AuthFlow.InitAuthentication(apsCred, redirectUrl);
            return Redirect(authenticationContext.AuthorizationURL);
        }

        [HttpGet]
        public ActionResult Get(string authorization_id, string oauth_token, string oauth_verifier)
        {
            var accessToken = queryBus.Send<GetTwitterAccessToken, string>(new GetTwitterAccessToken() {
                AuthorizationId = authorization_id,
                OauthToken = oauth_token,
                OauthVerifier = oauth_verifier
            }).Result;

            return Redirect("http://localhost:50985?twitterAccessToken=" + accessToken);
        }
    }
}
