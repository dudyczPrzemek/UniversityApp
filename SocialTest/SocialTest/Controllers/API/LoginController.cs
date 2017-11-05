using InstaSharp;
using LinqToTwitter;
using Microsoft.AspNetCore.Mvc;
using SocialTest.Services;
using System.Collections.Generic;
using Tweetinvi;
using Tweetinvi.Models;

namespace SocialTest.Controllers
{
    public class LoginController : Controller
    {
        private IAuthenticationContext _authenticationContext;

        public LoginController ()
        {
            var redirectUrl = @"http://localhost:51621/api/twitter";
            var consKey = "WdraGJz5UUR2l8Y35g9zBrwOw";
            var consSecret = "oxurh7hr5HxkCUChNwnshmCjNjOhdhE5r307AOEhZtxYKbPbyd";
            var apsCred = new ConsumerCredentials(consKey, consSecret);
            _authenticationContext = AuthFlow.InitAuthentication(apsCred, redirectUrl);
        }

        [HttpGet("api/login")]
        public ActionResult Get()
        {
            //return InstagramAuth();
            //return FacebookAuth();
            return TweeterAuth();
        }

        private ActionResult InstagramAuth()
        {
            var clientId = "9e2868731b544ed39a731c2111f4bfd2";
            var clientSecretId = "fa72e90415eb479a9c25185f15d7c79a";
            var redirectUri = @"http://localhost:51621/api/instagram";
            var realtimeUri = "";

            var config = new InstagramConfig(clientId, clientSecretId, redirectUri, realtimeUri);

            var scopes = new List<OAuth.Scope>();
            scopes.Add(InstaSharp.OAuth.Scope.Likes);
            scopes.Add(InstaSharp.OAuth.Scope.Comments);
            scopes.Add(InstaSharp.OAuth.Scope.Basic);
            scopes.Add(InstaSharp.OAuth.Scope.Follower_List);
            scopes.Add(InstaSharp.OAuth.Scope.Relationships);
            scopes.Add(InstaSharp.OAuth.Scope.Public_Content);

            var link = InstaSharp.OAuth.AuthLink(config.OAuthUri + "authorize", config.ClientId, config.RedirectUri, scopes, InstaSharp.OAuth.ResponseType.Code);

            return Redirect(link);
        }

        private ActionResult FacebookAuth()
        {
            var accessToken = "1578280192264123|sgVHK5fFAb6GH4xne-tULAJ2Fts";
            var applicationId = "1578280192264123";
            var redirectUri2 = @"http://localhost:51621/api/facebook";
            var redirectUrl = "https://www.facebook.com/v2.10/dialog/oauth?client_id=" + applicationId + "&redirect_uri="+ redirectUri2 + "&scope=user_friends,read_custom_friendlists";
            return Redirect(redirectUrl);
        }

        private ActionResult TweeterAuth()
        {
            return new RedirectResult(_authenticationContext.AuthorizationURL);
        }

        [HttpGet("api/twitter")]
        public ActionResult Get(string authorization_id, string oauth_token, string oauth_verifier)
        {
            var userCreds = AuthFlow.CreateCredentialsFromVerifierCode(oauth_verifier, authorization_id);
            var user = Tweetinvi.User.GetAuthenticatedUser(userCreds);
            var r = Request;
            return null;
        }
    }
}
