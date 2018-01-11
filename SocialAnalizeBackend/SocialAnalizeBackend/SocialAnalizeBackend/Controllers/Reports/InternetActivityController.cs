using GoldenEye.Backend.Core.DDD.Queries;
using Microsoft.AspNetCore.Mvc;
using SA.Contracts.Reports.InternetActivity;
using SA.Contracts.Reports.InternetActivity.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA.WebApi.Controllers.Reports
{
    [Route("api/[controller]")]
    public class InternetActivityController : Controller
    {
        private readonly IQueryBus queryBus;

        public InternetActivityController(IQueryBus queryBus)
        {
            this.queryBus = queryBus;
        }

        [HttpGet]
        public async Task<JsonResult> Get(int userId)
        {
            var result = await queryBus.Send<GetUserInternetActivity, InternetActivityData>(new GetUserInternetActivity()
            {
                UserId = userId
            });

            var hourActivityData = result.HourActivityDetails;
            var hashtagDetails = result.HashtagsDetails;
            return new JsonResult(new {instagramHourActivity = GetSocialHourData(hourActivityData, "Instagram"),
                twitterHourActivity = GetSocialHourData(hourActivityData, "Twitter"),
                hashtagDetails = hashtagDetails });
        }

        private IList<HourActivityJsonResult> GetSocialHourData(IList<HourActivityDetails> dest, string social)
        {
            var result = new List<HourActivityJsonResult>();
            var hourArray = new string[] {"00:00","01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00",
            "12:00","13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00"};
            for(var i = 0; i <= 23; i++)
            {
                var hourCount = dest.Where(x => x.Hour == i && x.Source.Equals(social)).FirstOrDefault();
                result.Add(new HourActivityJsonResult
                {
                    name = hourArray[i],
                    value = hourCount == null? 0 : hourCount.Mentions
                });
            }
            return result;
        }
    }
}
