using GoldenEye.Backend.Core.DDD.Queries;
using Newtonsoft.Json;
using SA.Contracts.Twitter.User.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Models;

namespace SA.Backend.Twitter.User
{
    public class TwitterUserQueryHandler : IAsyncQueryHandler<GetTwitterAccessToken, string>
    {
        public Task<string> Handle(GetTwitterAccessToken authData)
        {
            TwitterGlobal.UserCredentials = AuthFlow.CreateCredentialsFromVerifierCode(authData.OauthVerifier, authData.AuthorizationId);
            var user = Tweetinvi.User.GetAuthenticatedUser(TwitterGlobal.UserCredentials);
            Auth.SetUserCredentials(TwitterGlobal.UserCredentials.ConsumerKey, TwitterGlobal.UserCredentials.ConsumerSecret, TwitterGlobal.UserCredentials.AccessToken, TwitterGlobal.UserCredentials.AccessTokenSecret);
            return Task.FromResult("at: " + TwitterGlobal.UserCredentials.AccessToken + "ats: "+ TwitterGlobal.UserCredentials.AccessTokenSecret);
        }
    }
}
