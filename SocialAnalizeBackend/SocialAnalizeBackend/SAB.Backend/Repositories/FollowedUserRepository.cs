using GoldenEye.Backend.Core.Context;
using GoldenEye.Backend.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using SA.Backend.DB;
using SA.Backend.Repositories.Interfaces;
using SA.Contracts.Base;
using SA.Contracts.Facebook.User;
using SA.Contracts.Instagram.User;
using SA.Contracts.Twitter;
using SA.Contracts.User;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA.Backend.Repositories
{
    public class FollowedUserRepository : IFollowedUserRepository
    {
        private SAContext Context;
        private readonly IRepository<user_tweets> userTweetsRepository;
        private readonly IRepository<instagram_media_recent> instagramMediaRecentRepository;
        private readonly IRepository<facebook_user> facebookUserRepository;
        private readonly IFacebookRepository facebookRepository;
        private readonly IInstagramRepository instagramRepository;
        private readonly ITwitterRepository twitterRepository;
        public FollowedUserRepository(
            SAContext context,
            IRepository<user_tweets> userTweetsRepository,
            IRepository<instagram_media_recent> instagramMediaRecentRepository,
            IRepository<facebook_user> facebookUserRepository,
            IFacebookRepository facebookRepository,
            IInstagramRepository instagramRepository,
            ITwitterRepository twitterRepository)
        {
            this.userTweetsRepository = userTweetsRepository;
            this.instagramMediaRecentRepository = instagramMediaRecentRepository;
            this.facebookUserRepository = facebookUserRepository;
            this.facebookRepository = facebookRepository;
            this.instagramRepository = instagramRepository;
            this.twitterRepository = twitterRepository;
            Context = context;
        }

        public FollowedUser FindUserWithFacebookId(string facebookId)
        {
            return Context.FollowedUser.FirstOrDefault(x => x.FacebookId.Equals(facebookId));
        }

        public FollowedUser FindUserWithInstagramId(string instagramId)
        {
            return Context.FollowedUser.FirstOrDefault(x => x.FacebookId.Equals(instagramId));
        }

        public FollowedUser FindUserWithTwitterId(string twitterId)
        {
            return Context.FollowedUser.FirstOrDefault(x => x.FacebookId.Equals(twitterId));
        }

        public FollowedUser AddFollowedUser(FollowedUser followedUser)
        {
            var addingResult = Context.FollowedUser.Add(followedUser);
            Context.SaveChanges();
            return addingResult.Entity;
        }

        public async Task<FollowedUser> RefreshFollowedUserData(FollowedUser followedUser, AccessTokensModel accessTokens)
        {
            if(followedUser.FacebookId != null && accessTokens.Facebook != null)
            {
                var facebookData = await facebookRepository.GetDataFromFacebook(followedUser.FacebookId, accessTokens.Facebook);
                facebookData.FollowedUser = followedUser;

                facebookUserRepository.Add(facebookData);
                facebookUserRepository.SaveChanges();
            }

            if(followedUser.InstagramId != null && accessTokens.Instagram != null)
            {
                var instagramData = await instagramRepository.GetInstagramData(followedUser.InstagramId, accessTokens.Instagram);
                instagramData.FollowedUser = followedUser;

                instagramMediaRecentRepository.Add(instagramData);
                instagramMediaRecentRepository.SaveChanges();
            }

            if(followedUser.TwitterId != null && accessTokens.Twitter != null)
            {
                var twitterData = await twitterRepository.GetTwitterData(followedUser.TwitterId);
                twitterData.FollowedUser = followedUser;

                userTweetsRepository.Add(twitterData);
                userTweetsRepository.SaveChanges();
            }
            return followedUser;
        }

        public IList<FollowedUser> GetFollowedUsers()
        {
            return Context.FollowedUser.Include("PersonalData").ToList();
        }
    }
}
