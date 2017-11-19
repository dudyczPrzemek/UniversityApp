using GoldenEye.Backend.Core.DDD.Queries;
using Newtonsoft.Json;
using SA.Contracts.Twitter.User.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;

namespace SA.Backend.Twitter.User
{
    public class TwitterUserQueryHandler : IAsyncQueryHandler<GetTwitterAccessToken, string>
    {
        public Task<string> Handle(GetTwitterAccessToken authData)
        {
            var userCreds = AuthFlow.CreateCredentialsFromVerifierCode(authData.OauthVerifier, authData.AuthorizationId);
            var user = Tweetinvi.User.GetAuthenticatedUser(userCreds);
            Auth.SetUserCredentials(userCreds.ConsumerKey, userCreds.ConsumerSecret, userCreds.AccessToken, userCreds.AccessTokenSecret);
            return Task.FromResult(userCreds.AccessToken);
        }
    }
}
