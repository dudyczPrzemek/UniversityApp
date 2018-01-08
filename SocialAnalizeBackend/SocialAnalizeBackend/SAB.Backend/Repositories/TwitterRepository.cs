using SA.Backend.Repositories.Interfaces;
using SA.Backend.Twitter;
using SA.Contracts.Twitter;
using SA.Contracts.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;

namespace SA.Backend.Repositories
{
    public class TwitterRepository : ITwitterRepository
    {
        public async Task<SearchUserModel> SearchForUser (string searchedUserName)
        {
            Auth.SetUserCredentials(TwitterGlobal.UserCredentials.ConsumerKey, TwitterGlobal.UserCredentials.ConsumerSecret, TwitterGlobal.UserCredentials.AccessToken, TwitterGlobal.UserCredentials.AccessTokenSecret);
            var searchUser = Tweetinvi.Search.SearchUsers(searchedUserName);
            return MapFromTwitterModel(searchUser);
        }

        private SearchUserModel MapFromTwitterModel(IEnumerable<Tweetinvi.Models.IUser> twitterModelArray)
        {
            var searchModel = new SearchUserModel();
            searchModel.SearchedUsers = new List<SearchUserUnitModel>();

            for (var i = 0; i < twitterModelArray.ToList().Count; i++)
            {
                searchModel.SearchedUsers.Add(new SearchUserUnitModel()
                {
                    TwitterId = twitterModelArray.ElementAt(i).Id.ToString(),
                    FullName = twitterModelArray.ElementAt(i).Name,
                    PhotoUrl = twitterModelArray.ElementAt(i).ProfileImageUrl
                });
            }
            return searchModel;
        }

        public async Task<user_tweets> GetTwitterData(string userTwitterId)
        {
            Auth.SetUserCredentials(TwitterGlobal.UserCredentials.ConsumerKey, TwitterGlobal.UserCredentials.ConsumerSecret, TwitterGlobal.UserCredentials.AccessToken, TwitterGlobal.UserCredentials.AccessTokenSecret);
            var tweets = Timeline.GetUserTimeline(userTwitterId);
            return new user_tweets()
            {
                Data = JsonSerializer.ToJson(tweets)
            };
        }
    }
}
