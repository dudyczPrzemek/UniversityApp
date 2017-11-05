using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialTest.Controllers.API
{
    public class InstContentController
    {
        [HttpGet("api/InstContent")]
        public JsonResult Get(string accessToken)
        {
            return new JsonResult(accessToken);
        }
    }
}
