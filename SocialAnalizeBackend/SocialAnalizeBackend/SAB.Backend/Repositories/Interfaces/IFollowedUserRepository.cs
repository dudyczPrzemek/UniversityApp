using GoldenEye.Backend.Core.Repositories;
using SA.Contracts.Base;
using SA.Contracts.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SA.Backend.Repositories.Interfaces
{
    public interface IFollowedUserRepository
    {
        FollowedUser FindUserWithFacebookId(string facebookId);
        FollowedUser FindUserWithInstagramId(string instagramId);
        FollowedUser FindUserWithTwitterId(string twitterId);
        FollowedUser AddFollowedUser(FollowedUser followedUser);
        Task<FollowedUser> RefreshFollowedUserData(FollowedUser followedUser, AccessTokensModel accessTokens);
        IList<FollowedUser> GetFollowedUsers();
    }
}
