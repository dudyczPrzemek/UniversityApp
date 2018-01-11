using GoldenEye.Backend.Core.DDD.Queries;
using Microsoft.AspNetCore.Mvc;
using SA.Contracts.Reports.Localization.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA.WebApi.Controllers.Reports
{
    [Route("api/[controller]")]
    public class LocalizationController : Controller
    {
        private readonly IQueryBus queryBus;

        public LocalizationController(IQueryBus queryBus)
        {
            this.queryBus = queryBus;
        }

        [HttpGet]
        public async Task<JsonResult> Get(int userId)
        {
            var result = await queryBus.Send<GetUserLocalization, IList<SA.Contracts.Reports.Localization.Localization>>(new GetUserLocalization()
            {
                UserId = userId
            });
            return new JsonResult(result);
        }
    }
}
