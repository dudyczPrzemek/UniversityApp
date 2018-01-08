using GoldenEye.Backend.Core.DDD.Commands;
using GoldenEye.Backend.Core.Repositories;
using SA.Backend.Repositories.Interfaces;
using SA.Contracts.Facebook.User;
using SA.Contracts.Instagram.User;
using SA.Contracts.Twitter;
using SA.Contracts.User;
using SA.Contracts.User.Commands;
using System.Threading.Tasks;

namespace SA.Backend.User
{
    public class UserCommandHandler : IAsyncCommandHandler<AddUser> 
    {
        private readonly IFollowedUserRepository followedUserRepository;

        public UserCommandHandler(IFollowedUserRepository followedUserRepository)
        {
            this.followedUserRepository = followedUserRepository;
        }

        public async Task Handle(AddUser userData)
        {
            if(userData.FacebookId != null)
            {
                var followedUser = followedUserRepository.FindUserWithFacebookId(userData.FacebookId);
                if(followedUser == null)
                {
                    var followedUserEntity = new FollowedUser()
                    {
                        FacebookId = userData.FacebookId,
                        PersonalData = new Contracts.Reports.PersonalData.PersonalData()
                        {
                            FirstName = userData.FirstName,
                            LastName = userData.LastName
                        }
                    };
                    followedUser = followedUserRepository.AddFollowedUser(followedUserEntity);
                }

                await followedUserRepository.RefreshFollowedUserData(followedUser, userData.AccessTokens);
            }

            if(userData.InstagramId != null)
            {
                var followedUser = followedUserRepository.FindUserWithInstagramId(userData.InstagramId);
                if(followedUser == null)
                {
                    var followedUserEntity = new FollowedUser()
                    {
                        InstagramId = userData.InstagramId,
                        PersonalData = new Contracts.Reports.PersonalData.PersonalData()
                        {
                            FirstName = userData.FirstName,
                            LastName = userData.LastName
                        }
                    };
                    followedUser = followedUserRepository.AddFollowedUser(followedUserEntity);
                }

                await followedUserRepository.RefreshFollowedUserData(followedUser, userData.AccessTokens);
            }

            if(userData.TwitterId != null)
            {
                var followedUser = followedUserRepository.FindUserWithTwitterId(userData.TwitterId);
                if (followedUser == null)
                {
                    var followedUserEntity = new FollowedUser()
                    {
                        FacebookId = userData.TwitterId,
                        PersonalData = new Contracts.Reports.PersonalData.PersonalData()
                        {
                            FirstName = userData.FirstName,
                            LastName = userData.LastName
                        }
                    };
                    followedUser = followedUserRepository.AddFollowedUser(followedUserEntity);
                }

                await followedUserRepository.RefreshFollowedUserData(followedUser, userData.AccessTokens);
            }
        }
    }
}
