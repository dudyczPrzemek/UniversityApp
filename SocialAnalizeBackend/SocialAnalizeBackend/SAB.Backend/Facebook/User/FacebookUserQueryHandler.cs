using GoldenEye.Backend.Core.DDD.Queries;
using GoldenEye.Backend.Core.Repositories;
using Newtonsoft.Json.Linq;
using SA.Contracts.Facebook;
using SA.Contracts.Facebook.User.Queries;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SA.Backend.Facebook.User
{
    public class FacebookUserQueryHandler : 
        IAsyncQueryHandler<GetFacebookUser, FacebookUser>,
        IAsyncQueryHandler<GetFacebookAccessToken, string>
    {
        private readonly IRepository<FacebookUser> repository;

        public FacebookUserQueryHandler(IRepository<FacebookUser> repository)
        {
            this.repository = repository;
        }
        public Task<FacebookUser> Handle(GetFacebookUser userData)
        {
            return repository.GetByIdAsync(userData.Id);
        }

        public Task<string> Handle(GetFacebookAccessToken authData)
        {
            return GetAccessToken(authData);
        }

        private async Task<string> GetAccessToken(GetFacebookAccessToken authData)
        {
            var requestUrl = @"https://graph.facebook.com/v2.10/oauth/access_token?" +
                                "client_id=" + authData.ApplicationId +
                                "&redirect_uri=" + authData.RedirectUrl +
                                "&client_secret=" + authData.ApplicationSecret +
                                "&code=" + authData.Code;
            var client = new HttpClient();
            var response = await client.GetAsync(requestUrl);
            var parsedResponse = await response.Content.ReadAsStringAsync();
            var json = JObject.Parse(parsedResponse);
            var accessToken = json["access_token"].ToString();
            return accessToken;
        }
    }
}
