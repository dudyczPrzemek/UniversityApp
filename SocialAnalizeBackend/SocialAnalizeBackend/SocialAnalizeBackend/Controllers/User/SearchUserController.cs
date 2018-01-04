using GoldenEye.Backend.Core.DDD.Commands;
using GoldenEye.Backend.Core.DDD.Queries;
using Microsoft.AspNetCore.Mvc;
using SA.Contracts.Facebook;
using SA.Contracts.User;
using SA.Contracts.User.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA.WebApi.Controllers.User
{
    [Route("api/[controller]")]
    public class SearchUserController : Controller
    {
        private readonly IQueryBus queryBus;
        private readonly ICommandBus commandBus;

        public SearchUserController(IQueryBus queryBus, ICommandBus commandBus)
        {
            this.queryBus = queryBus;
            this.commandBus = commandBus;
        }

        [HttpGet]
        public async Task<JsonResult> Get (string userId, string facebookAccessToken, string instagramAccessToken, string twitterAccessToken)
        {
            var searchResult =  await queryBus.Send<GetSearchedUser, SearchUserModel>(new GetSearchedUser()
            {
                AccessTokens = new Contracts.Base.AccessTokensModel()
                {
                    Facebook = facebookAccessToken,
                    Instagram = instagramAccessToken,
                    Twitter = twitterAccessToken
                },
                UserId = userId
            });

            return new JsonResult(searchResult);
        }

        [HttpPost]
        public async Task<Boolean> Post([FromBody]SearchUserUnitModel searchUser)
        {
            Console.Write("dsadas");
            return true;
        }
    }
}
