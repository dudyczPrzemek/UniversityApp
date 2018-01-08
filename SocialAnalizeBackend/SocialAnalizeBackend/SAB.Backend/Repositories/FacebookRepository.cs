using Newtonsoft.Json;
using SA.Backend.Repositories.Interfaces;
using SA.Contracts.Facebook;
using SA.Contracts.Facebook.User;
using SA.Contracts.User;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SA.Backend.Repositories
{
    public class FacebookRepository : IFacebookRepository
    {
        public async Task<SearchUserModel> SearchForUser(string searchedUserName, string accessToken)
        {
            var client = new HttpClient();
            var searchUrl = @"https://graph.facebook.com/search?q=" + searchedUserName + "&type=user&access_token=" + accessToken;
            var response = await client.GetAsync(searchUrl);
            var parsedResponse = await response.Content.ReadAsStringAsync();

            var facebookModel = JsonConvert.DeserializeObject<FacebookSearchUserListResult>(parsedResponse);
            return MapFromFacebookModel(facebookModel);
        }

        private SearchUserModel MapFromFacebookModel(FacebookSearchUserListResult facebookModel)
        {
            var searchModel = new SearchUserModel();
            searchModel.SearchedUsers = new List<SearchUserUnitModel>();

            searchModel.Paging = facebookModel.paging?.next;
            for (var i = 0; i < facebookModel.data.Length; i++)
            {
                searchModel.SearchedUsers.Add(new SearchUserUnitModel()
                {
                    FacebookId = facebookModel.data[i].id,
                    FullName = facebookModel.data[i].name
                });
            }
            return searchModel;
        }

        public async Task<facebook_user> GetDataFromFacebook(string facebookUserId, string accessToken)
        {
            var client = new HttpClient();
            var userUrl = @"https://graph.facebook.com/"+ facebookUserId + "?fields=first_name,last_name,picture,age_range,gender&access_token=" + accessToken;
            var response = await client.GetAsync(userUrl);
            var data = await response.Content.ReadAsStringAsync();
            return new facebook_user()
            {
                Data = data
            };
        }
    }
}
