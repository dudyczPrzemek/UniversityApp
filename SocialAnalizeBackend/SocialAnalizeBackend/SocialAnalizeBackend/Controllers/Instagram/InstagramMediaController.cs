using GoldenEye.Backend.Core.DDD.Commands;
using GoldenEye.Backend.Core.DDD.Queries;
using Microsoft.AspNetCore.Mvc;
using SA.Contracts.Instagram.User.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA.WebApi.Controllers.Instagram
{
    [Route("api/[controller]")]
    public class InstagramMediaController : Controller
    {
        public IQueryBus queryBus { get; set; }
        public ICommandBus commandBus { get; set; }

        public InstagramMediaController(IQueryBus queryBus, ICommandBus commandBus)
        {
            this.queryBus = queryBus;
            this.commandBus = commandBus;
        }

        [HttpGet]
        public async Task<string> Get(string accessToken, int userId)
        {
            await commandBus.Send(new RefreshInstagramRecentMedia()
            {
                AccessToken = accessToken,
                UserId = userId
            });

            return "Ok";
        }
    }
}
