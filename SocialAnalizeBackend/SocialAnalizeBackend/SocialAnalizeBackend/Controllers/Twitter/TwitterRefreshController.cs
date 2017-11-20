using GoldenEye.Backend.Core.DDD.Commands;
using Microsoft.AspNetCore.Mvc;
using SA.Contracts.Twitter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA.WebApi.Controllers.Twitter
{
    [Route("api/[controller]")]
    public class TwitterRefreshController : Controller
    {
        private readonly ICommandBus commandBus;

        public TwitterRefreshController(ICommandBus commandBus)
        {
            this.commandBus = commandBus;
        }

        [HttpGet]
        public async Task<string> Get(string at, string ats)
        {
            await commandBus.Send(new RefreshTwitterUserData()
            {
                UserId = 1,
                AccessToken = at,
                AccessTokenSecret = ats
            });
            return "Ok";
        }
    }
}
