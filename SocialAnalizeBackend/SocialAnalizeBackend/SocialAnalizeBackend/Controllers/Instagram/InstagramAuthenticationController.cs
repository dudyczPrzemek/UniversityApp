using GoldenEye.Backend.Core.DDD.Queries;
using InstaSharp;
using Microsoft.AspNetCore.Mvc;
using SA.Contracts.Instagram.User.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA.WebApi.Controllers.Instagram
{
    [Route("api/[controller]")]
    public class InstagramAuthenticationController : Controller
    {
        public IQueryBus queryBus;

        public InstagramAuthenticationController(IQueryBus queryBus)
        {
            this.queryBus = queryBus;
        }

        [HttpGet]
        [Route("authenticate")]
        public ActionResult Get()
        {
            var clientId = "59012b845588456990c43c91eff4a160";
            var clientSecretId = "30e266947792420baf3eed7e17260772";
            var redirectUri = @"http://localhost:50985/api/instagramAuthentication";
            var realtimeUri = "";

            var config = new InstagramConfig(clientId, clientSecretId, redirectUri, realtimeUri);

            var scopes = new List<OAuth.Scope>();
            scopes.Add(OAuth.Scope.Likes);
            scopes.Add(OAuth.Scope.Comments);
            scopes.Add(OAuth.Scope.Basic);
            scopes.Add(OAuth.Scope.Follower_List);
            scopes.Add(OAuth.Scope.Relationships);
            scopes.Add(OAuth.Scope.Public_Content);

            var link = OAuth.AuthLink(config.OAuthUri + "authorize", config.ClientId, config.RedirectUri, scopes, InstaSharp.OAuth.ResponseType.Code);
            return Redirect(link);
        }

        [HttpGet]
        public string Get(string code)
        {
            return queryBus.Send<GetInstagramAccessToken, string>(new GetInstagramAccessToken() {
                ClientId = "59012b845588456990c43c91eff4a160",
                ClientSecretId = "30e266947792420baf3eed7e17260772",
                Code = code,
                ReturnUrl = @"http://localhost:50985/api/instagramAuthentication"
            }).Result;
        }
    }
}
