using Newtonsoft.Json;
using SA.Backend.Repositories.Interfaces;
using SA.Contracts.Instagram;
using SA.Contracts.Instagram.User;
using SA.Contracts.User;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SA.Backend.Repositories
{
    public class InstagramRepository : IInstagramRepository
    {
        public async Task<SearchUserModel> SearchForUser (string searchedUserName, string accessToken)
        {
            var client = new HttpClient();
            var searchUrl = new Uri(@"https://api.instagram.com/v1/users/search?q=" + searchedUserName + "&access_token=" + accessToken);
            var response = await client.GetAsync(searchUrl);
            var parsedResponse = await response.Content.ReadAsStringAsync();

            var instagramSearchArray = JsonConvert.DeserializeObject<InstagramSearchUserListModel>(parsedResponse);
            return MapFromInstagramModel(instagramSearchArray);
        }

        private SearchUserModel MapFromInstagramModel(InstagramSearchUserListModel instagramModel)
        {
            var searchModel = new SearchUserModel();
            searchModel.SearchedUsers = new List<SearchUserUnitModel>();

            for (var i = 0; i < instagramModel.data.Length; i++)
            {
                searchModel.SearchedUsers.Add(new SearchUserUnitModel()
                {
                    InstagramId = instagramModel.data[i].id,
                    FullName = instagramModel.data[i].full_name,
                    PhotoUrl = instagramModel.data[i].profile_picture
                });
            }
            return searchModel;
        }

        public async Task<instagram_media_recent> GetInstagramData(string userInstagramId, string accessToken)
        {
            var client = new HttpClient();
            var mediaUri = new Uri(@"https://api.instagram.com/v1/users/"+ userInstagramId + "/media/recent/?access_token=" + accessToken);
            var response = await client.GetAsync(mediaUri);
            var data =  await response.Content.ReadAsStringAsync();
            return new instagram_media_recent()
            {
                Data = data
            };
        }
    }
}
