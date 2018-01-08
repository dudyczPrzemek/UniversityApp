using GoldenEye.Backend.Core.DDD.Queries;
using Microsoft.AspNetCore.Mvc;
using SA.Contracts.User.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA.WebApi.Controllers.FollowedUser
{
    [Route("api/[controller]")]
    public class FollowedUserController : Controller
    {
        private IQueryBus queryBus;

        public FollowedUserController(IQueryBus queryBus)
        {
            this.queryBus = queryBus;
        }

        [HttpGet]
        public async Task<JsonResult> GetFollowedUsers()
        {
            var resultList = await queryBus.Send<GetFollowedUsers, IList<SA.Contracts.User.FollowedUser>>(new GetFollowedUsers());
            return new JsonResult(new {followedUserArray = resultList.ToArray() });
        }
    }
}
