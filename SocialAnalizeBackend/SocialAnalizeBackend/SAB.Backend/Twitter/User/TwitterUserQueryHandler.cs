using GoldenEye.Backend.Core.DDD.Queries;
using GoldenEye.Backend.Core.Repositories;
using Newtonsoft.Json;
using SA.Backend.Repositories.Interfaces;
using SA.Contracts.Twitter;
using SA.Contracts.Twitter.User.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Models;

namespace SA.Backend.Twitter.User
{
    public class TwitterUserQueryHandler : 
        IAsyncQueryHandler<GetTwitterAccessToken, string>,
        IAsyncQueryHandler<RefreshTwitterDataUser, bool>
    {
        private readonly IRepository<user_tweets> userTweetsRepository;
        private readonly ITwitterRepository twitterRepository;
        private readonly IFollowedUserRepository followedUserRepository;

        public TwitterUserQueryHandler(IRepository<user_tweets> userTweetsRepository,
            ITwitterRepository twitterRepository,
            IFollowedUserRepository followedUserRepository)
        {
            this.userTweetsRepository = userTweetsRepository;
            this.twitterRepository = twitterRepository;
            this.followedUserRepository = followedUserRepository;
        }

        public Task<string> Handle(GetTwitterAccessToken authData)
        {
            TwitterGlobal.UserCredentials = AuthFlow.CreateCredentialsFromVerifierCode(authData.OauthVerifier, authData.AuthorizationId);
            var user = Tweetinvi.User.GetAuthenticatedUser(TwitterGlobal.UserCredentials);
            Auth.SetUserCredentials(TwitterGlobal.UserCredentials.ConsumerKey, TwitterGlobal.UserCredentials.ConsumerSecret, TwitterGlobal.UserCredentials.AccessToken, TwitterGlobal.UserCredentials.AccessTokenSecret);
            return Task.FromResult("at: " + TwitterGlobal.UserCredentials.AccessToken + "ats: "+ TwitterGlobal.UserCredentials.AccessTokenSecret);
        }

        public async Task<bool> Handle(RefreshTwitterDataUser refreshData)
        {
            var followedUser = followedUserRepository.FindUserWithTwitterId(refreshData.TwitterUserId);
            var twitterData = await twitterRepository.GetTwitterData(refreshData.TwitterUserId);

            twitterData.FollowedUser = followedUser;
            userTweetsRepository.Add(twitterData);
            userTweetsRepository.SaveChanges();
            return true;
        }
    }
}
