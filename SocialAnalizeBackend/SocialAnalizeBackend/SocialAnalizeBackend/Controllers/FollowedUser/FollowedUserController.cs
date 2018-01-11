using GoldenEye.Backend.Core.DDD.Queries;
using Microsoft.AspNetCore.Mvc;
using SA.Contracts.Facebook.User.Queries;
using SA.Contracts.Twitter.User.Queries;
using SA.Contracts.Instagram.User.Queries;
using SA.Contracts.User.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using SA.Contracts.User;
using SA.Contracts.Base;
using GoldenEye.Backend.Core.DDD.Commands;
using SA.Contracts.User.Commands;

namespace SA.WebApi.Controllers.FollowedUser
{
    [Route("api/[controller]")]
    public class FollowedUserController : Controller
    {
        private IQueryBus queryBus;
        private ICommandBus commandBus;

        public FollowedUserController(IQueryBus queryBus, ICommandBus commandBus)
        {
            this.queryBus = queryBus;
            this.commandBus = commandBus;
        }

        [HttpGet]
        public async Task<JsonResult> GetFollowedUsers()
        {
            var resultList = await queryBus.Send<GetFollowedUsers, IList<SA.Contracts.User.FollowedUser>>(new GetFollowedUsers());
            return new JsonResult(new {followedUserArray = resultList.ToArray() });
        }

        [HttpGet]
        [Route("refreshFacebook")]
        public async Task<JsonResult> RefreshFacebookFollowedUserData (string facebookId, string accessToken)
        {
            var result = await queryBus.Send<RefreshIntagramUserData, bool>(new RefreshIntagramUserData()
            {
                AccessToken = accessToken,
                FacebookUserId = facebookId
            });
            return new JsonResult(new { success = result });
        }

        [HttpGet]
        [Route("refreshInstagram")]
        public async Task<JsonResult> RefreshInstagramFollowedUserData(string instagramId, string accessToken)
        {
            var result = await queryBus.Send<RefreshInstagramUserData, bool>(new RefreshInstagramUserData()
            {
                AccessToken = accessToken,
                InstagramUserId = instagramId
            });
            return new JsonResult(new { success = result });
        }

        [HttpGet]
        [Route("refreshTwitter")]
        public async Task<JsonResult> RefreshTwitterFollowedUserData(string twitterId, string accessToken)
        {
            var result = await queryBus.Send<RefreshTwitterDataUser, bool>(new RefreshTwitterDataUser()
            {
                TwitterUserId = twitterId
            });
            return new JsonResult(new { success = result });
        }

        [HttpPut]
        public async Task<JsonResult> Put([FromBody]JObject payload)
        {
            var userToUpdate = payload["searchUser"].ToObject<SearchUserUnitModel>();
            var accessTokens = payload["accessTokens"].ToObject<AccessTokensModel>();

            await commandBus.Send<UpdateFollowedUser>(new UpdateFollowedUser()
            {
                AccessTokens = accessTokens,
                FacebookId = userToUpdate.FacebookId,
                InstagramId = userToUpdate.InstagramId,
                TwitterId = userToUpdate.TwitterId,
                UserId = userToUpdate.UserId
            });
            return new JsonResult(new { success = true});
        }
    }
}
