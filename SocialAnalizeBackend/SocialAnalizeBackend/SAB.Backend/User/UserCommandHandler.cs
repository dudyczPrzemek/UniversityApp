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
    public class UserCommandHandler : 
        IAsyncCommandHandler<AddUser>,
        IAsyncCommandHandler<UpdateFollowedUser>
    {
        private readonly IFollowedUserRepository followedUserRepository;
        private readonly CRUDRepository<FollowedUser> followedUserCrudRepository;

        public UserCommandHandler(IFollowedUserRepository followedUserRepository, CRUDRepository<FollowedUser> followedUserCrudRepository)
        {
            this.followedUserRepository = followedUserRepository;
            this.followedUserCrudRepository = followedUserCrudRepository;
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

        public async Task Handle(UpdateFollowedUser updateUserData)
        {
            var followedUser = followedUserRepository.FindFollowedUserById(updateUserData.UserId);
            if(updateUserData.FacebookId != null)
            {
                followedUser.FacebookId = updateUserData.FacebookId;

                followedUserCrudRepository.Update(followedUser);
                followedUserCrudRepository.SaveChanges();
            }

            else if (updateUserData.InstagramId != null)
            {
                followedUser.InstagramId = updateUserData.InstagramId;

                followedUserCrudRepository.Update(followedUser);
                followedUserCrudRepository.SaveChanges();
            }

            else if (updateUserData.TwitterId != null)
            {
                followedUser.TwitterId = updateUserData.TwitterId;

                followedUserCrudRepository.Update(followedUser);
                followedUserCrudRepository.SaveChanges();
            }

            var updatedUser = followedUserRepository.FindFollowedUserById(updateUserData.UserId);
            await followedUserRepository.RefreshFollowedUserData(updatedUser, updateUserData.AccessTokens);
        }
    }
}
