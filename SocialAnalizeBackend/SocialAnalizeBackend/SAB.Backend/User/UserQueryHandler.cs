using GoldenEye.Backend.Core.DDD.Queries;
using Newtonsoft.Json;
using SA.Backend.Repositories.Interfaces;
using SA.Backend.Twitter;
using SA.Contracts.Facebook;
using SA.Contracts.Instagram;
using SA.Contracts.Twitter;
using SA.Contracts.User;
using SA.Contracts.User.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;

namespace SA.Backend.User
{
    public class UserQueryHandler : IAsyncQueryHandler<GetSearchedUser, SearchUserModel>
    {
        private IFacebookRepository facebookRepository;
        private IInstagramRepository instagramRepository;
        private ITwitterRepository twitterRepository;

        public UserQueryHandler(IFacebookRepository _facebookRepo, IInstagramRepository _instagramRepo, ITwitterRepository _twitterRepo)
        {
            facebookRepository = _facebookRepo;
            instagramRepository = _instagramRepo;
            twitterRepository = _twitterRepo;
        }
        public async Task<SearchUserModel> Handle(GetSearchedUser searchedUserData)
        {
            if (searchedUserData.AccessTokens.Facebook != "null")
            {
                return await facebookRepository.SearchForUser(searchedUserData.UserId, searchedUserData.AccessTokens.Facebook);
            }
            else if (searchedUserData.AccessTokens.Instagram != "null")
            {
                return await instagramRepository.SearchForUser(searchedUserData.UserId, searchedUserData.AccessTokens.Instagram);
            }
            else if (searchedUserData.AccessTokens.Twitter != "null")
            {
                return await twitterRepository.SearchForUser(searchedUserData.UserId);
            }
            return null;
        }
    }
}
