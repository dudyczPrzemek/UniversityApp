using GoldenEye.Backend.Core.DDD.Commands;
using GoldenEye.Backend.Core.DDD.Queries;
using Microsoft.AspNetCore.Mvc;
using SA.Contracts.Facebook;
using SA.Contracts.Facebook.User.Commands;
using SA.Contracts.Facebook.User.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SA.WebApi.Controllers.Facebook
{
    [Route("api/[controller]")]
    public class FacebookUserController : Controller
    {
        private readonly IQueryBus queryBus;
        private readonly ICommandBus commandBus;

        public FacebookUserController(IQueryBus queryBus, ICommandBus commandBus)
        {
            this.queryBus = queryBus;
            this.commandBus = commandBus;
        }

        [HttpGet]
        public Task<FacebookUser> Get(int id)
        {
            return queryBus.Send<GetFacebookUser, FacebookUser>(new GetFacebookUser { Id = id});
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody]CreateFacebookUser command)
        {
            await commandBus.Send(command);
            return Ok();
        }
    } 
}
