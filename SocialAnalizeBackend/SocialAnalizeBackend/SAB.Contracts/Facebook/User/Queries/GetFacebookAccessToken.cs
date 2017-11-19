using GoldenEye.Backend.Core.DDD.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Contracts.Facebook.User.Queries
{
    public class GetFacebookAccessToken : IQuery<string>
    {
        public string ApplicationId { get; set; }
        public string ApplicationSecret { get; set; }
        public string RedirectUrl { get; set; }
        public string Code { get; set; }
    }
}
