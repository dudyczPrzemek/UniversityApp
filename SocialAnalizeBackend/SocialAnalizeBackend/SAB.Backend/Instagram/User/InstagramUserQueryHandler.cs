using GoldenEye.Backend.Core.DDD.Queries;
using GoldenEye.Backend.Core.Repositories;
using Newtonsoft.Json.Linq;
using SA.Backend.Repositories.Interfaces;
using SA.Contracts.Instagram.User;
using SA.Contracts.Instagram.User.Queries;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SA.Backend.Instagram.User
{
    public class InstagramUserQueryHandler : 
        IAsyncQueryHandler<GetInstagramAccessToken, string>,
        IAsyncQueryHandler<RefreshInstagramUserData, bool>
    {
        private readonly IRepository<instagram_media_recent> instagramUserRepository;
        private readonly IInstagramRepository instagramRepository;
        private readonly IFollowedUserRepository followedUserRepository;

        public InstagramUserQueryHandler(IRepository<instagram_media_recent> instagramUserRepository,
            IInstagramRepository instagramRepository,
            IFollowedUserRepository followedUserRepository)
        {
            this.instagramRepository = instagramRepository;
            this.instagramUserRepository = instagramUserRepository;
            this.followedUserRepository = followedUserRepository;
        }

        public Task<string> Handle(GetInstagramAccessToken authData)
        {
            return GetAccessToken(authData);
        }

        private async Task<string> GetAccessToken(GetInstagramAccessToken authData)
        {
            var client = new HttpClient();
            var postValues = new List<KeyValuePair<string, string>>
                             {
                                 new KeyValuePair<string, string>
                                     ("client_id",
                                      authData.ClientId),
                                 new KeyValuePair<string, string>
                                     ("client_secret",
                                      authData.ClientSecretId),
                                 new KeyValuePair<string, string>
                                     ("grant_type",
                                      "authorization_code"),
                                 new KeyValuePair<string, string>
                                     ("redirect_uri",
                                      authData.ReturnUrl),
                                 new KeyValuePair<string, string>("code", authData.Code)
                             };

            // now encode the values
            var content = new FormUrlEncodedContent(postValues);
            var authLinkUri = new Uri(@"https://api.instagram.com/oauth/access_token");
            // make request for auth token
            var response = await client.PostAsync(authLinkUri, content);

            var parsedResponse = await response.Content.ReadAsStringAsync();
            var json = JObject.Parse(parsedResponse);
            var accessToken = json["access_token"].ToString();
            return accessToken;
        }

        public async Task<bool> Handle(RefreshInstagramUserData refreshData)
        {
            var followedUser = followedUserRepository.FindUserWithInstagramId(refreshData.InstagramUserId);
            var instagramData = await instagramRepository.GetInstagramData(refreshData.InstagramUserId, refreshData.AccessToken);

            instagramData.FollowedUser = followedUser;
            instagramUserRepository.Add(instagramData);
            instagramUserRepository.SaveChanges();
            return true;
        }
    }
}
